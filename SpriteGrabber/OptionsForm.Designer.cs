namespace SpriteGrabber
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lblSetRectangleColor = new System.Windows.Forms.Label();
            this.btnSetRectangleColor = new System.Windows.Forms.Button();
            this.btnSettingRectangleColor = new System.Windows.Forms.Button();
            this.nudCheckerTileWidth = new System.Windows.Forms.NumericUpDown();
            this.lblCheckerTileWidth = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckerTileWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblSetRectangleColor
            // 
            resources.ApplyResources(this.lblSetRectangleColor, "lblSetRectangleColor");
            this.lblSetRectangleColor.Name = "lblSetRectangleColor";
            // 
            // btnSetRectangleColor
            // 
            this.btnSetRectangleColor.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnSetRectangleColor, "btnSetRectangleColor");
            this.btnSetRectangleColor.Name = "btnSetRectangleColor";
            this.btnSetRectangleColor.UseVisualStyleBackColor = false;
            this.btnSetRectangleColor.Click += new System.EventHandler(this.btnSetRectangleColor_Click);
            // 
            // btnSettingRectangleColor
            // 
            this.btnSettingRectangleColor.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnSettingRectangleColor, "btnSettingRectangleColor");
            this.btnSettingRectangleColor.Name = "btnSettingRectangleColor";
            this.btnSettingRectangleColor.UseVisualStyleBackColor = false;
            this.btnSettingRectangleColor.Click += new System.EventHandler(this.btnSettingRectangleColor_Click);
            // 
            // nudCheckerTileWidth
            // 
            resources.ApplyResources(this.nudCheckerTileWidth, "nudCheckerTileWidth");
            this.nudCheckerTileWidth.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudCheckerTileWidth.Name = "nudCheckerTileWidth";
            // 
            // lblCheckerTileWidth
            // 
            resources.ApplyResources(this.lblCheckerTileWidth, "lblCheckerTileWidth");
            this.lblCheckerTileWidth.Name = "lblCheckerTileWidth";
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblCheckerTileWidth);
            this.Controls.Add(this.nudCheckerTileWidth);
            this.Controls.Add(this.btnSetRectangleColor);
            this.Controls.Add(this.lblSetRectangleColor);
            this.Controls.Add(this.btnSettingRectangleColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OptionsForm";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckerTileWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnSettingRectangleColor;
        private System.Windows.Forms.Button btnSetRectangleColor;
        private System.Windows.Forms.Label lblSetRectangleColor;
        private System.Windows.Forms.NumericUpDown nudCheckerTileWidth;
        private System.Windows.Forms.Label lblCheckerTileWidth;
        private System.Windows.Forms.Button btnApply;
    }
}