using System;
using System.Windows.Forms;

namespace SpriteGrabber
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void ApplySettings()
        {
            SpriteGrabber.Properties.Settings.Default.SetRectangleColor = btnSetRectangleColor.BackColor;
            SpriteGrabber.Properties.Settings.Default.SettingRectangleColor = btnSettingRectangleColor.BackColor;
            SpriteGrabber.Properties.Settings.Default.CheckerTileWidth = (int)nudCheckerTileWidth.Value;
        }

        private void btnSettingRectangleColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                btnSettingRectangleColor.BackColor = colorDialog.Color;
        }

        private void btnSetRectangleColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                btnSetRectangleColor.BackColor = colorDialog.Color;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ApplySettings();

            SpriteGrabber.Properties.Settings.Default.Save();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            btnSetRectangleColor.BackColor = SpriteGrabber.Properties.Settings.Default.SetRectangleColor;
            btnSettingRectangleColor.BackColor = SpriteGrabber.Properties.Settings.Default.SettingRectangleColor;
            nudCheckerTileWidth.Value = SpriteGrabber.Properties.Settings.Default.CheckerTileWidth;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }
    }
}
