namespace SpriteGrabber
{
    partial class CaptureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureForm));
            this.sfdDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblSprite = new System.Windows.Forms.Label();
            this.txtSpriteFile = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCollect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOffset = new System.Windows.Forms.Label();
            this.nudOffsetY = new System.Windows.Forms.NumericUpDown();
            this.nudOffsetX = new System.Windows.Forms.NumericUpDown();
            this.cbPreferredColor = new System.Windows.Forms.ComboBox();
            this.lblSpriteSize = new System.Windows.Forms.Label();
            this.txtSpriteSize = new System.Windows.Forms.TextBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lblX = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblXValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblY = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblYValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbSwapFrames = new System.Windows.Forms.CheckBox();
            this.pbCaptureImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetX)).BeginInit();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // sfdDialog
            // 
            this.sfdDialog.DefaultExt = "*.png";
            resources.ApplyResources(this.sfdDialog, "sfdDialog");
            // 
            // lblSprite
            // 
            resources.ApplyResources(this.lblSprite, "lblSprite");
            this.lblSprite.Name = "lblSprite";
            // 
            // txtSpriteFile
            // 
            resources.ApplyResources(this.txtSpriteFile, "txtSpriteFile");
            this.txtSpriteFile.Name = "txtSpriteFile";
            this.txtSpriteFile.ReadOnly = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCollect
            // 
            resources.ApplyResources(this.btnCollect, "btnCollect");
            this.btnCollect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOffset
            // 
            resources.ApplyResources(this.lblOffset, "lblOffset");
            this.lblOffset.Name = "lblOffset";
            // 
            // nudOffsetY
            // 
            resources.ApplyResources(this.nudOffsetY, "nudOffsetY");
            this.nudOffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudOffsetY.Name = "nudOffsetY";
            this.nudOffsetY.ValueChanged += new System.EventHandler(this.nudOffsetY_ValueChanged);
            // 
            // nudOffsetX
            // 
            resources.ApplyResources(this.nudOffsetX, "nudOffsetX");
            this.nudOffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudOffsetX.Name = "nudOffsetX";
            this.nudOffsetX.ValueChanged += new System.EventHandler(this.nudOffsetX_ValueChanged);
            // 
            // cbPreferredColor
            // 
            resources.ApplyResources(this.cbPreferredColor, "cbPreferredColor");
            this.cbPreferredColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPreferredColor.FormattingEnabled = true;
            this.cbPreferredColor.Name = "cbPreferredColor";
            this.cbPreferredColor.SelectedValueChanged += new System.EventHandler(this.cbPreferredColor_SelectedValueChanged);
            // 
            // lblSpriteSize
            // 
            resources.ApplyResources(this.lblSpriteSize, "lblSpriteSize");
            this.lblSpriteSize.Name = "lblSpriteSize";
            // 
            // txtSpriteSize
            // 
            resources.ApplyResources(this.txtSpriteSize, "txtSpriteSize");
            this.txtSpriteSize.Name = "txtSpriteSize";
            this.txtSpriteSize.ReadOnly = true;
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblX,
            this.lblXValue,
            this.lblY,
            this.lblYValue});
            resources.ApplyResources(this.ssStatus, "ssStatus");
            this.ssStatus.Name = "ssStatus";
            // 
            // lblX
            // 
            this.lblX.Name = "lblX";
            resources.ApplyResources(this.lblX, "lblX");
            // 
            // lblXValue
            // 
            resources.ApplyResources(this.lblXValue, "lblXValue");
            this.lblXValue.Name = "lblXValue";
            // 
            // lblY
            // 
            this.lblY.Name = "lblY";
            resources.ApplyResources(this.lblY, "lblY");
            // 
            // lblYValue
            // 
            resources.ApplyResources(this.lblYValue, "lblYValue");
            this.lblYValue.Name = "lblYValue";
            // 
            // cbSwapFrames
            // 
            resources.ApplyResources(this.cbSwapFrames, "cbSwapFrames");
            this.cbSwapFrames.Name = "cbSwapFrames";
            this.cbSwapFrames.UseVisualStyleBackColor = true;
            this.cbSwapFrames.CheckedChanged += new System.EventHandler(this.cbSwapFrames_CheckedChanged);
            // 
            // pbCaptureImage
            // 
            resources.ApplyResources(this.pbCaptureImage, "pbCaptureImage");
            this.pbCaptureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCaptureImage.Name = "pbCaptureImage";
            this.pbCaptureImage.TabStop = false;
            this.pbCaptureImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDifferenceImage_Paint);
            this.pbCaptureImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDifferenceImage_MouseDown);
            this.pbCaptureImage.MouseLeave += new System.EventHandler(this.pbCaptureImage_MouseLeave);
            this.pbCaptureImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDifferenceImage_MouseMove);
            this.pbCaptureImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDifferenceImage_MouseUp);
            // 
            // CaptureForm
            // 
            this.AcceptButton = this.btnCollect;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.cbSwapFrames);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.txtSpriteSize);
            this.Controls.Add(this.lblSpriteSize);
            this.Controls.Add(this.cbPreferredColor);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.nudOffsetY);
            this.Controls.Add(this.nudOffsetX);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCollect);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSpriteFile);
            this.Controls.Add(this.lblSprite);
            this.Controls.Add(this.pbCaptureImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaptureForm";
            this.Load += new System.EventHandler(this.CompareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetX)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptureImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCaptureImage;
        private System.Windows.Forms.SaveFileDialog sfdDialog;
        private System.Windows.Forms.Label lblSprite;
        private System.Windows.Forms.TextBox txtSpriteFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.NumericUpDown nudOffsetY;
        private System.Windows.Forms.NumericUpDown nudOffsetX;
        private System.Windows.Forms.ComboBox cbPreferredColor;
        private System.Windows.Forms.Label lblSpriteSize;
        private System.Windows.Forms.TextBox txtSpriteSize;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblX;
        private System.Windows.Forms.ToolStripStatusLabel lblXValue;
        private System.Windows.Forms.ToolStripStatusLabel lblY;
        private System.Windows.Forms.ToolStripStatusLabel lblYValue;
        private System.Windows.Forms.CheckBox cbSwapFrames;
    }
}