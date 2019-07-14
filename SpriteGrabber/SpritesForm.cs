using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpriteGrabber
{
    public partial class SpritesForm : Form
    {
        private MainForm mainForm;

        public SpritesForm()
        {
            InitializeComponent();
        }

        public SpritesForm(MainForm parent, List<Bitmap> sprites) : this()
        {
            mainForm = parent;

            int index = 0;

            Rectangle rectangle = getEqualizedRectangle(sprites);

            ilSprites.ImageSize = new Size(rectangle.Width, rectangle.Height);

            foreach (Bitmap sprite in sprites)
            {
                String key = index.ToString();

                ilSprites.Images.Add(key, equalizeSprite(sprite, rectangle));

                ListViewItem listViewItem = lvSprites.Items.Add(key);
                listViewItem.ImageKey = key;

                index++;
            }
        }

        private Rectangle getEqualizedRectangle(List<Bitmap> sprites)
        {
            int width = 0;
            int height = 0;

            foreach (Bitmap sprite in sprites)
            {
                if (sprite.Width > width)
                    width = sprite.Width;

                if (sprite.Height > height)
                    height = sprite.Height;
            }

            return new Rectangle(0, 0, width, height);
        }

        private Bitmap equalizeSprite(Bitmap sprite, Rectangle rectangle)
        {
            Bitmap bmp = new Bitmap(rectangle.Width, rectangle.Height);

            int offX = (rectangle.Width - sprite.Width)/2;
            int offY = (rectangle.Height - sprite.Height)/2;

            for (int x = 0; x < sprite.Width; x++)
                for (int y = 0; y < sprite.Height; y++)
                {
                    Color color = sprite.GetPixel(x, y);
                    bmp.SetPixel(x + offX, y + offY, color);
                }

            return bmp;
        }

        private void lvSprites_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Image image = ilSprites.Images[e.Item.ImageKey];
            pbSprite.Image = image;
        }

        private void tbZoom_Scroll(object sender, EventArgs e)
        {
            if (lvSprites.SelectedItems.Count == 0)
                return;

            Image image = ilSprites.Images[lvSprites.SelectedIndices[0]];

            if (image == null)
                return;

            Bitmap bmp = new Bitmap(image, new Size(tbZoom.Value*image.Width, tbZoom.Value*image.Height));

            pbSprite.Image = bmp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSpriteBaseName.Text))
            {
                MessageBox.Show("You must select a sprite basename");

                return;
            }

            if (fbdFolder.ShowDialog() != DialogResult.OK)
            {
                mainForm.AddMessage("User aborted");

                return;
            }

            int index = 0;

            mainForm.AddMessage("Saving sprites in: " + fbdFolder.SelectedPath);

            if (lvSprites.SelectedItems.Count == 0)
            {
                foreach (Image image in ilSprites.Images)
                {
                    String filename = System.IO.Path.Combine(fbdFolder.SelectedPath, String.Format("{0}{1}.png", txtSpriteBaseName.Text, index));

                    index++;

                    try
                    {
                        image.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch (Exception ex)
                    {
                        mainForm.AddMessage("Exception: " + ex.Message);
                    }
                }
            }
            else
            {
                foreach (ListViewItem item in lvSprites.SelectedItems)
                {
                    String filename = System.IO.Path.Combine(fbdFolder.SelectedPath, String.Format("{0}{1}.png", txtSpriteBaseName.Text, index));

                    index++;

                    try
                    {
                        Image image = ilSprites.Images[item.ImageKey];

                        if (image != null)
                            image.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch (Exception ex)
                    {
                        mainForm.AddMessage("Exception: " + ex.Message);

                    }
                }
            }

            mainForm.AddMessage(index.ToString() + " sprite saved");
        }

        private void miClear_Click(object sender, EventArgs e)
        {
            ilSprites.Images.Clear();
            lvSprites.Items.Clear();
            mainForm.clearSprites();
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvSprites.SelectedItems[0];

            if (item == null)
                return;

            pbSprite.Image = null;

            int index;

            if (int.TryParse(item.ImageKey, out index))
            {
                ilSprites.Images.RemoveByKey(item.ImageKey);
                lvSprites.Items.RemoveByKey(item.ImageKey);
                mainForm.discardSprite(index);
            }
        }

        private void cmsSprites_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            miDelete.Enabled = (lvSprites.SelectedItems.Count != 0);
            miClear.Enabled = (lvSprites.Items.Count != 0);
        }
    }
}
