using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpriteGrabber
{
    public partial class CaptureForm : Form
    {
        private enum DrawingState
        {
            Idle,
            Setting,
            Set
        }

        private enum PreferredColor
        {
            Color1,
            Color2
        }

        private MainForm mainForm;
        private Point startPoint;
        private Point endPoint;
        private Bitmap bmp1;
        private Bitmap bmp2;
        private Color backgroundColor;
        private DrawingState drawingState = DrawingState.Idle;
        private PreferredColor preferredColor = PreferredColor.Color1;

        public CaptureForm()
        {
            InitializeComponent();
        }

        public CaptureForm(MainForm parent, Image image1, Image image2, Color bgColor) : this()
        {
            mainForm = parent;

            bmp1 = new Bitmap(image1);
            bmp2 = new Bitmap(image2);

            backgroundColor = bgColor;

            pbCaptureImage.Image = getDifferenceBmp(bmp1, bmp2, 0, 0, bgColor);
        }

        private Bitmap getDifferenceBmp(Bitmap bmp1, Bitmap bmp2, int offsetX, int offsetY, Color bgColor)
        {
            Bitmap bmp = new Bitmap(bmp1.Width, bmp1.Height);

            for (int x = 0; x < bmp1.Width; x++)
                for (int y = 0; y < bmp1.Height; y++)
                {
                    if ((x + offsetX < 0) || (y + offsetY < 0))
                        continue;

                    if ((x + offsetX >= bmp1.Width) || (y + offsetY >= bmp1.Height))
                        continue;

                    Color color1, color2;

                    color1 = bmp1.GetPixel(x, y);
                    color2 = bmp2.GetPixel(x + offsetX, y + offsetY);

                    if (color1 != color2)
                    {
                        if (color1 == bgColor)
                            bmp.SetPixel(x, y, Color.Transparent);
                        else
                        {
                            if (preferredColor == PreferredColor.Color1)
                                bmp.SetPixel(x, y, color1);
                            else
                                bmp.SetPixel(x, y, color2);
                        }
                    }
                    else
                        bmp.SetPixel(x, y, Color.Transparent);
                }

            return bmp;
        }

        private Rectangle getRectangle()
        {
            int width;
            int height;
            int startX;
            int startY;

            startX = Math.Min(startPoint.X, endPoint.X);
            startY = Math.Min(startPoint.Y, endPoint.Y);
            width = Math.Abs(endPoint.X - startPoint.X);
            height = Math.Abs(endPoint.Y - startPoint.Y);

            Rectangle rectangle = new Rectangle(startX, startY, width, height);

            return rectangle;
        }

        private Bitmap getSprite()
        {
            Rectangle rectangle = getRectangle();
            Bitmap sprite = null;

            if (rectangle.Width > 0 && rectangle.Height > 0)
            {
                Bitmap bmpFull = new Bitmap(pbCaptureImage.Image);
                sprite = bmpFull.Clone(rectangle, bmpFull.PixelFormat);
            }
            else
                sprite = new Bitmap(pbCaptureImage.Image);

            return sprite;
        }

        private void Optimize()
        {
            Rectangle rectangle = getRectangle();

            if (rectangle.Width == 0 || rectangle.Height == 0)
                return;

            Bitmap bmp = new Bitmap(pbCaptureImage.Image);

            if (bmp.Width == 0 || bmp.Height == 0)
                return;

            List<Point> vertices = new List<Point>();
            bool foundVertice = false;
            Color noColor = Color.FromArgb(0, 0, 0, 0);

            int x, y;
            int x0 = rectangle.X;
            int y0 = rectangle.Y;
            int x1 = rectangle.X+rectangle.Width;
            int y1 = rectangle.Y+rectangle.Height;

            for (y = y0; y < y1 && !foundVertice; y++)
                for (x = x0; x < x1 && !foundVertice; x++)
                {
                    Color color = bmp.GetPixel(x, y);

                    if (color != backgroundColor && color != Color.Transparent && color != noColor)
                    {
                        vertices.Add(new Point(x, y));
                        foundVertice = true;
                    }
                }

            foundVertice = false;

            for (x = x1-1; x >= x0 && !foundVertice; x--)
                for (y = y0; y < y1 && !foundVertice; y++)
                {
                    Color color = bmp.GetPixel(x, y);

                    if (color != backgroundColor && color != Color.Transparent && color != noColor)
                    {
                        vertices.Add(new Point(x, y));
                        foundVertice = true;
                    }
                }

            foundVertice = false;

            for (x = x0; x < x1 && !foundVertice; x++)
                for (y = y1-1; y >= x0 && !foundVertice; y--)
                {
                    Color color = bmp.GetPixel(x, y);

                    if (color != backgroundColor && color != Color.Transparent && color != noColor)
                    {
                        vertices.Add(new Point(x, y));
                        foundVertice = true;
                    }
                }

            foundVertice = false;

            for (y = y1 - 1; y >= y0 && !foundVertice; y--)
                for (x = x1 - 1; x >= x0 && !foundVertice; x--)
                {
                    Color color = bmp.GetPixel(x, y);

                    if (color != backgroundColor && color != Color.Transparent && color != noColor)
                    {
                        vertices.Add(new Point(x, y));
                        foundVertice = true;
                    }
                }

            int maxX = 0, maxY = 0;

            foreach (Point vertice in vertices)
            {
                if (vertice.X > maxX)
                    maxX = vertice.X;

                if (vertice.Y > maxY)
                    maxY = vertice.Y;
            }

            int minX = maxX, minY = maxY;

            foreach (Point vertice in vertices)
            {
                if (vertice.X < minX)
                    minX = vertice.X;

                if (vertice.Y < minY)
                    minY = vertice.Y;
            }

            startPoint.X = minX;
            startPoint.Y = minY;

            endPoint.X = maxX;
            endPoint.Y = maxY;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sfdDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                Bitmap bmp = getSprite();

                bmp.Save(sfdDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);

                txtSpriteFile.Text = sfdDialog.FileName;

                mainForm.AddMessage("Saving sprite to: " + sfdDialog.FileName);
            }
            catch (Exception ex)
            {
                mainForm.AddMessage("Exception:" + ex.Message);
            }
        }

        private void pbDifferenceImage_MouseDown(object sender, MouseEventArgs e)
        {
            drawingState = DrawingState.Setting;
            startPoint = e.Location;
            pbCaptureImage.Refresh();
        }

        private void pbDifferenceImage_MouseMove(object sender, MouseEventArgs e)
        {
            txtX.Text = e.X.ToString();
            txtY.Text = e.Y.ToString();

            if (drawingState != DrawingState.Setting)
                return;

            endPoint = e.Location;
            pbCaptureImage.Refresh();
        }

        private void pbDifferenceImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawingState != DrawingState.Setting)
                return;

            drawingState = DrawingState.Set;
            endPoint = e.Location;

            Optimize();

            Rectangle rectangle = getRectangle();

            txtSpriteSize.Text = rectangle.Width.ToString() + "x" + rectangle.Height.ToString();

            pbCaptureImage.Refresh();

            drawingState = DrawingState.Idle;
        }

        private void pbDifferenceImage_Paint(object sender, PaintEventArgs e)
        {
            if (drawingState == DrawingState.Setting)
                e.Graphics.DrawRectangle(new Pen(Color.Yellow), getRectangle());
            else if (drawingState == DrawingState.Set)
                e.Graphics.DrawRectangle(new Pen(Color.Red), getRectangle());
        }

        private void pbCaptureImage_MouseLeave(object sender, EventArgs e)
        {
            txtX.Text = txtY.Text = "";
        }

        private void nudOffsetX_ValueChanged(object sender, EventArgs e)
        {
            pbCaptureImage.Image = getDifferenceBmp(bmp1, bmp2, (int)nudOffsetX.Value, (int)nudOffsetY.Value, backgroundColor);
        }

        private void nudOffsetY_ValueChanged(object sender, EventArgs e)
        {
            pbCaptureImage.Image = getDifferenceBmp(bmp1, bmp2, (int)nudOffsetX.Value, (int)nudOffsetY.Value, backgroundColor);
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
            cbPreferredColor.DataSource = Enum.GetNames(typeof(PreferredColor));
        }

        private void cbPreferredColor_SelectedValueChanged(object sender, EventArgs e)
        {
            preferredColor = (PreferredColor)Enum.Parse(typeof(PreferredColor), cbPreferredColor.Text);
            pbCaptureImage.Image = getDifferenceBmp(bmp1, bmp2, (int)nudOffsetX.Value, (int)nudOffsetY.Value, backgroundColor);
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = getSprite();

            mainForm.storeSprite(bitmap);

            mainForm.AddMessage("Sprite stored");

            Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
