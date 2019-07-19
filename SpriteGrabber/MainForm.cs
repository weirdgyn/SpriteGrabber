﻿using Accord.Video.FFMPEG;
using SprinterPublishing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Drawing.Imaging;

namespace SpriteGrabber
{
    public partial class MainForm : Form
    {
        Color bacgroundColor;
        List<Bitmap> lstSprites;
        SplashForm splashForm;

        public MainForm()
        {
            lstSprites = new List<Bitmap>();
            splashForm = new SplashForm();
            splashForm.Visible = false;

            InitializeComponent();
        }

        public void storeSprite(Bitmap sprite)
        {
            lstSprites.Add(sprite);
            txtSprites.Text = lstSprites.Count.ToString();
            AddMessage(SpriteGrabber.Properties.Resources.SpriteStored);
        }

        public void clearSprites()
        {
            lstSprites.Clear();
            txtSprites.Text = "";

            AddMessage(SpriteGrabber.Properties.Resources.SpriteCollectionCleared);
        }

        public void discardSprite(int index)
        {
            lstSprites.RemoveAt(index);
            txtSprites.Text = lstSprites.Count.ToString();
            AddMessage(SpriteGrabber.Properties.Resources.SpriteRemoved);
        }

        public Bitmap createChecker(int width, int height, int tileWidth, Color color1, Color color2)
        {
            Bitmap bitmap = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                int hTiles = width / tileWidth;
                int vTiles = height / tileWidth;
                SolidBrush brush1 = new SolidBrush(color1);
                SolidBrush brush2 = new SolidBrush(color2);

                for (int x = 0; x < hTiles; x++)
                    for (int y = 0; y < vTiles; y++)
                        if ((x + y) % 2 == 0)
                            g.FillRectangle(brush1, x * tileWidth, y * tileWidth, tileWidth, tileWidth);
                        else
                            g.FillRectangle(brush2, x * tileWidth, y * tileWidth, tileWidth, tileWidth);
            }

            return bitmap;
        }

        private void loadGIF()
        {
            Image image = Image.FromFile(txtBundleFile.Text);

            FrameDimension dimension = new FrameDimension(image.FrameDimensionsList[0]);

            int frames = image.GetFrameCount(dimension);

            txtMaxFrames.Text = frames.ToString();

            nudFrame1.Maximum = nudFrame2.Maximum = frames - 1;

            if (frames < 2)
                return;

            nudFrame1.Value = 0;
            image.SelectActiveFrame(dimension, 0);
            Bitmap bmp1 = new Bitmap(image);
            pbFrame1.Image = bmp1;
            pbFrame1.Width = bmp1.Width;
            pbFrame1.Height = bmp1.Height;

            nudFrame2.Value = 1;
            image.SelectActiveFrame(dimension, 1);
            Bitmap bmp2 = new Bitmap(image);
            pbFrame2.Image = bmp2;
            pbFrame2.Width = bmp2.Width;
            pbFrame2.Height = bmp2.Height;
        }

        private void loadMNG()
        {
            MNG mng = new MNG();

            mng.Load(txtBundleFile.Text);

            int frames = mng.NumEmbeddedPNG;

            txtMaxFrames.Text = frames.ToString();

            nudFrame1.Maximum = nudFrame2.Maximum = frames - 1;

            if (frames < 2)
                return;

            nudFrame1.Value = 0;
            Bitmap bmp1 = mng.ToBitmap(0);
            pbFrame1.Image = bmp1;
            pbFrame1.Width = bmp1.Width;
            pbFrame1.Height = bmp1.Height;

            nudFrame2.Value = 1;
            Bitmap bmp2 = mng.ToBitmap(1);
            pbFrame2.Image = bmp2;
            pbFrame2.Width = bmp2.Width;
            pbFrame2.Height = bmp2.Height;
        }

        private void loadAVI()
        {
            using (Accord.Video.FFMPEG.VideoFileReader videoFileReader = new VideoFileReader())
            {
                videoFileReader.Open(txtBundleFile.Text);

                long frames = videoFileReader.FrameCount;

                nudFrame1.Maximum = nudFrame2.Maximum = frames - 1;

                nudFrame1.Value = 0;

                if (frames < 2)
                    return;

                txtMaxFrames.Text = frames.ToString();

                nudFrame1.Value = 0;
                Bitmap bmp1 = videoFileReader.ReadVideoFrame(0);
                pbFrame1.Image = bmp1;
                pbFrame1.Width = bmp1.Width;
                pbFrame1.Height = bmp1.Height;

                nudFrame2.Value = 1;
                Bitmap bmp2 = videoFileReader.ReadVideoFrame(1);
                pbFrame2.Image = bmp2;
                pbFrame2.Width = bmp2.Width;
                pbFrame2.Height = bmp2.Height;
            }
        }

        private void loadFile()
        {
            if (!System.IO.File.Exists(txtBundleFile.Text))
                return;

            try
            {
                string extension = System.IO.Path.GetExtension(txtBundleFile.Text).ToLower();

                switch (extension)
                {
                    case ".mng":
                        loadMNG();
                        getBackgroundColor();
                        break;

                    case ".avi":
                        loadAVI();
                        getBackgroundColor();
                        break;

                    case ".gif":
                        loadGIF();
                        getBackgroundColor();
                        break;


                    default:
                        AddMessage(SpriteGrabber.Properties.Resources.UnknownFormat);
                        break;
                }
            }
            catch (Exception ex)
            {
                AddMessage(SpriteGrabber.Properties.Resources.Exception + ex.Message);
            }
        }

        private void pickBackgroundColor(PictureBox pictureBox, Point location)
        {
            if (pictureBox.Image == null)
                return;

            Bitmap bmp = new Bitmap(pictureBox.Image);
            bacgroundColor = bmp.GetPixel(location.X, location.Y);
            string colorString = "#" + bacgroundColor.R.ToString("X2") + bacgroundColor.G.ToString("X2") + bacgroundColor.B.ToString("X2");
            txtBGColor.Text = colorString;
            AddMessage(SpriteGrabber.Properties.Resources.BackgroundColorSelected + colorString);
        }

        private void getBackgroundColor()
        {
            if (pbFrame1.Image == null || pbFrame2.Image == null)
                return;

            Bitmap bmp = new Bitmap(pbFrame1.Image);
            Dictionary<Color, Int32> frequencies = new Dictionary<Color, Int32>();

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color color = bmp.GetPixel(x, y);

                    if (!frequencies.ContainsKey(color))
                        frequencies.Add(color, 0);
                    else
                        frequencies[color]++;
                }

            Int32 hfreq = frequencies.Values.Max();

            bacgroundColor = frequencies.FirstOrDefault(x => x.Value == hfreq).Key;
            string colorString = "#" + bacgroundColor.R.ToString("X2") + bacgroundColor.G.ToString("X2") + bacgroundColor.B.ToString("X2");
            txtBGColor.Text = colorString;
        }

        public void AddMessage(string message)
        {
            ListViewItem item = new ListViewItem(DateTime.Now.ToLongTimeString());
            item.SubItems.Add(message);
            lvMessages.Items.Add(item);
            item.EnsureVisible();
            chTime.Width = chMessage.Width = -2;
        }

        private void getFrame(PictureBox frameBox, NumericUpDown frameCounter)
        {
            string extension = System.IO.Path.GetExtension(txtBundleFile.Text).ToLower();
            long frames = 0;

            switch (extension)
            {
                case ".gif":
                    Image image = Image.FromFile(txtBundleFile.Text);
                    FrameDimension dimension = new FrameDimension(image.FrameDimensionsList[0]);

                    frames = image.GetFrameCount(dimension);
                    frameCounter.Maximum = frames - 1;

                    if (frameCounter.Value < frames)
                    {
                        image.SelectActiveFrame(dimension, (int)frameCounter.Value);

                        Bitmap bmp = new Bitmap(image);
                        frameBox.Image = bmp;
                        getBackgroundColor();

                        AddMessage(SpriteGrabber.Properties.Resources.Frame + frameCounter.Value.ToString());
                    }

                    break;

                case ".mng":
                    MNG mng = new MNG();

                    mng.Load(txtBundleFile.Text);

                    frames = mng.NumEmbeddedPNG;
                    frameCounter.Maximum = frames - 1;

                    if (frameCounter.Value < frames)
                    {
                        Bitmap bmp = mng.ToBitmap((int)frameCounter.Value);
                        frameBox.Image = bmp;
                        getBackgroundColor();

                        AddMessage(SpriteGrabber.Properties.Resources.Frame + frameCounter.Value.ToString());
                    }

                    break;

                case ".avi":
                    using (var videoFileReader = new VideoFileReader())
                    {

                        videoFileReader.Open(txtBundleFile.Text);

                        frames = videoFileReader.FrameCount;

                        frameCounter.Maximum = frames - 1;

                        if (frameCounter.Value < frames)
                        {
                            Bitmap bmp = videoFileReader.ReadVideoFrame((int)frameCounter.Value);
                            frameBox.Image = bmp;
                            getBackgroundColor();

                            AddMessage(SpriteGrabber.Properties.Resources.Frame + frameCounter.Value.ToString());
                        }
                    }
                    break;

                default:
                    AddMessage(SpriteGrabber.Properties.Resources.UnknownFormat);
                    break;
            }
        }

        private void nudFrame2_ValueChanged(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(txtBundleFile.Text))
                return;

            try
            {
                getFrame(pbFrame2, nudFrame2);
            }
            catch (Exception ex)
            {
                AddMessage(ex.Message);
            }
        }

        private void nudFrame1_ValueChanged(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(txtBundleFile.Text))
                return;

            try
            {
                getFrame(pbFrame1, nudFrame1);
            }
            catch (Exception ex)
            {
                AddMessage(ex.Message);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (ofdDialog.ShowDialog() != DialogResult.OK)
                return;

            txtBundleFile.Text = ofdDialog.FileName;
            AddMessage(SpriteGrabber.Properties.Resources.LoadFile + ofdDialog.FileName);

            loadFile();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (pbFrame1.Image == null || pbFrame2.Image == null)
                return;

            if (pbFrame1.Image.Height != pbFrame2.Image.Height || pbFrame1.Image.Width != pbFrame2.Image.Width)
                return;

            CaptureForm compareForm = new CaptureForm(this,pbFrame1.Image, pbFrame2.Image, bacgroundColor);

            compareForm.Show();
        }

        private void pbFrame1_MouseDown(object sender, MouseEventArgs e)
        {
            pickBackgroundColor(pbFrame1, e.Location);
        }

        private void pbFrame2_MouseDown(object sender, MouseEventArgs e)
        {
            pickBackgroundColor(pbFrame2, e.Location);
        }

        private void btnExchangeFrames_Click(object sender, EventArgs e)
        {
            int frame1 = (int)nudFrame1.Value;
            nudFrame1.Value = nudFrame2.Value;
            nudFrame2.Value = frame1;
        }

        private void btnSprites_Click(object sender, EventArgs e)
        {
            if (lstSprites == null || lstSprites.Count == 0)
                return;

            SpritesForm spritesForm = new SpritesForm(this,lstSprites);
            spritesForm.Show();
        }

        private void cmsMessages_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            miClear.Enabled = miSave.Enabled = (lvMessages.Items.Count != 0);
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog logSaveDialog = new SaveFileDialog();

            logSaveDialog.Title = SpriteGrabber.Properties.Resources.LogFileDialogTitle;
            logSaveDialog.DefaultExt = "*.txt";
            logSaveDialog.Filter = SpriteGrabber.Properties.Resources.LogFileDialogFilter;

            if (logSaveDialog.ShowDialog() != DialogResult.OK)
                return;

            System.Text.StringBuilder text = new System.Text.StringBuilder();

            foreach (ListViewItem item in lvMessages.Items)
                text.AppendLine(String.Format("{0} - {1}", item.Text, item.SubItems[1].Text));

            System.IO.File.WriteAllText(logSaveDialog.FileName, text.ToString());
        }

        private void miClear_Click(object sender, EventArgs e)
        {
            lvMessages.Items.Clear();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            splashForm.Hide();
            this.Show();
            this.WindowState = FormWindowState.Normal;
            tmrSplash.Stop();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Hide();
            splashForm.Show();
        }

        private void txtBundleFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = (string[])e.Data.GetData("FileName");

            txtBundleFile.Text = data[0];

            AddMessage(SpriteGrabber.Properties.Resources.LoadFile + data[0]);

            loadFile();
        }

        private void txtBundleFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileName"))
            {
                string[] data = (string[])e.Data.GetData("FileName");

                if (data!=null && data.Length>0 && !String.IsNullOrWhiteSpace(data[0]))
                {
                    string extension = System.IO.Path.GetExtension(data[0]).ToLower();
                    if (extension.Equals(".mng") || extension.Equals(".avi") || extension.Equals(".gif"))
                    {
                        e.Effect = DragDropEffects.Copy;
                        return;
                    }
                }
            }

            e.Effect = DragDropEffects.None;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();

            optionsForm.ShowDialog();
        }
    }
}
