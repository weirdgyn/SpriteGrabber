using Accord.Video.FFMPEG;
using SprinterPublishing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpriteGrabber
{
    public partial class MainForm : Form
    {
        Color bgColor;
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
        }

        private void LoadMNG()
        {
            MNG mng = new MNG();

            mng.Load(txtBundleFile.Text);

            int frames = mng.NumEmbeddedPNG;

            txtMaxFrames.Text = frames.ToString();

            nudFrame1.Maximum = nudFrame2.Maximum = frames - 1;

            nudFrame1.Value = 0;

            if (frames < 2)
                return;

            nudFrame1.Value = 0;
            nudFrame2.Value = 1;

            Bitmap bmp1 = mng.ToBitmap(0);
            pbFrame1.Image = bmp1;
            pbFrame1.Width = bmp1.Width;
            pbFrame1.Height = bmp1.Height;

            Bitmap bmp2 = mng.ToBitmap(1);
            pbFrame2.Image = bmp2;
            pbFrame2.Width = bmp2.Width;
            pbFrame2.Height = bmp2.Height;
        }

        private void LoadAVI()
        {
            using (Accord.Video.FFMPEG.VideoFileReader videoFileReader = new VideoFileReader())
            {
                videoFileReader.Open(txtBundleFile.Text);

                long frames = videoFileReader.FrameCount;

                nudFrame1.Maximum = nudFrame2.Maximum = frames - 1;

                nudFrame1.Value = 0;

                if (frames < 2)
                    return;

                nudFrame1.Value = 0;
                nudFrame2.Value = 1;

                txtMaxFrames.Text = frames.ToString();

                Bitmap bmp1 = videoFileReader.ReadVideoFrame(0);
                pbFrame1.Image = bmp1;
                pbFrame1.Width = bmp1.Width;
                pbFrame1.Height = bmp1.Height;

                Bitmap bmp2 = videoFileReader.ReadVideoFrame(1);
                pbFrame2.Image = bmp2;
                pbFrame2.Width = bmp2.Width;
                pbFrame2.Height = bmp2.Height;
            }
        }

        private void LoadFile()
        {
            if (!System.IO.File.Exists(txtBundleFile.Text))
                return;

            try
            {
                string extension = System.IO.Path.GetExtension(txtBundleFile.Text).ToLower();

                switch (extension)
                {
                    case ".mng":
                        LoadMNG();
                        break;

                    case ".avi":
                        LoadAVI();
                        break;

                    default:
                        AddMessage("Unknown format");
                        break;
                }
            }
            catch (Exception ex)
            {
                AddMessage("Exception: " + ex.Message);
            }
        }

        private void PickColor(PictureBox pictureBox, Point location)
        {
            if (pictureBox.Image == null)
                return;

            Bitmap bmp = new Bitmap(pictureBox.Image);
            bgColor = bmp.GetPixel(location.X, location.Y);
            string colorString = "#" + bgColor.R.ToString("X2") + bgColor.G.ToString("X2") + bgColor.B.ToString("X2");
            txtBGColor.Text = colorString;
            AddMessage("Background color selected:" + colorString);
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
                case ".mng":
                    MNG mng = new MNG();

                    mng.Load(txtBundleFile.Text);

                    frames = mng.NumEmbeddedPNG;
                    frameCounter.Maximum = frames - 1;

                    if (frameCounter.Value < frames)
                    {
                        Bitmap bmp = mng.ToBitmap((int)frameCounter.Value);
                        frameBox.Image = bmp;
                        AddMessage("Frame: #" + frameCounter.Value.ToString());
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
                            AddMessage("Frame: #" + frameCounter.Value.ToString());
                        }
                    }
                    break;

                default:
                    AddMessage("Unknown format");
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
            AddMessage("Load file: " + ofdDialog.FileName);

            LoadFile();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (pbFrame1.Image == null || pbFrame2.Image == null)
                return;

            if (pbFrame1.Image.Height != pbFrame2.Image.Height || pbFrame1.Image.Width != pbFrame2.Image.Width)
                return;

            CaptureForm compareForm = new CaptureForm(this,pbFrame1.Image, pbFrame2.Image, bgColor);

            compareForm.Show();
        }

        private void pbFrame1_MouseDown(object sender, MouseEventArgs e)
        {
            PickColor(pbFrame1, e.Location);
        }

        private void pbFrame2_MouseDown(object sender, MouseEventArgs e)
        {
            PickColor(pbFrame2, e.Location);
        }

        private void btnExchangeFrames_Click(object sender, EventArgs e)
        {
            int frame1 = (int)nudFrame1.Value;
            nudFrame1.Value = nudFrame2.Value;
            nudFrame2.Value = frame1;
        }

        private void btnSprites_Click(object sender, EventArgs e)
        {
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

            logSaveDialog.Title = "Log file";
            logSaveDialog.DefaultExt = "*.txt";
            logSaveDialog.Filter = "Text files (*.txt)|*.txt";

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

            LoadFile();
        }

        private void txtBundleFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileName"))
            {
                string[] data = (string[])e.Data.GetData("FileName");

                if (data!=null && data.Length>0 && !String.IsNullOrWhiteSpace(data[0]))
                {
                    string extension = System.IO.Path.GetExtension(data[0]).ToLower();
                    if (extension.Equals(".mng") || extension.Equals(".avi"))
                    {
                        e.Effect = DragDropEffects.Copy;
                        return;
                    }
                }
            }

            e.Effect = DragDropEffects.None;
        }
    }
}
