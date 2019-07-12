using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            foreach (Bitmap sprite in sprites)
            {
                String key = String.Format("Sprite{0}",index);

                if (sprite.Height > ilSprites.ImageSize.Height || sprite.Width > ilSprites.ImageSize.Width)
                {
                    int height = Math.Max(ilSprites.ImageSize.Height, sprite.Height);
                    int width = Math.Max(ilSprites.ImageSize.Width, sprite.Width);

                    ilSprites.ImageSize = new Size(width, height);
                }

                ilSprites.Images.Add(key, sprite);

                ListViewItem listViewItem = lvSprites.Items.Add(key);
                listViewItem.ImageKey = key;

                index++;
            }
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
            if (fbdFolder.ShowDialog() != DialogResult.OK)
            {
                mainForm.AddMessage("User aborted");

                return;
            }

            if (String.IsNullOrWhiteSpace(txtSpriteBaseName.Text))
            {
                MessageBox.Show(this, "You must select a sprite basename");

                return;
            }

            int index = 0;

            foreach (Image image in ilSprites.Images)
            {
                String filename = System.IO.Path.Combine(fbdFolder.SelectedPath, String.Format("{0}{1}.png", txtSpriteBaseName.Text, index));

                index++;

                try
                {
                    image.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                    mainForm.AddMessage("Saving sprites in " + fbdFolder.SelectedPath);
                }
                catch (Exception ex)
                {
                    mainForm.AddMessage("Exception: " + ex.Message);
                }
            }

            mainForm.AddMessage(index.ToString() + " sprite saved");
        }
    }
}
