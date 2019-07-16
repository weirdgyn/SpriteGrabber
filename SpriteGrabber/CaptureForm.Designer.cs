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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpriteSize = new System.Windows.Forms.TextBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lblX = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblXValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblY = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblYValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbCaptureImage = new System.Windows.Forms.PictureBox();
            this.cbSwapFrames = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetX)).BeginInit();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // sfdDialog
            // 
            this.sfdDialog.DefaultExt = "*.png";
            this.sfdDialog.Filter = "PNG image file *.png|*.png";
            // 
            // lblSprite
            // 
            this.lblSprite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSprite.AutoSize = true;
            this.lblSprite.Location = new System.Drawing.Point(12, 348);
            this.lblSprite.Name = "lblSprite";
            this.lblSprite.Size = new System.Drawing.Size(53, 13);
            this.lblSprite.TabIndex = 1;
            this.lblSprite.Text = "Sprite file:";
            // 
            // txtSpriteFile
            // 
            this.txtSpriteFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpriteFile.Location = new System.Drawing.Point(71, 344);
            this.txtSpriteFile.Name = "txtSpriteFile";
            this.txtSpriteFile.ReadOnly = true;
            this.txtSpriteFile.Size = new System.Drawing.Size(279, 20);
            this.txtSpriteFile.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(356, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCollect
            // 
            this.btnCollect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCollect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCollect.Location = new System.Drawing.Point(193, 367);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(60, 23);
            this.btnCollect.TabIndex = 4;
            this.btnCollect.Text = "Collect";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(175, 428);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOffset
            // 
            this.lblOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(12, 322);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(38, 13);
            this.lblOffset.TabIndex = 18;
            this.lblOffset.Text = "Offset:";
            // 
            // nudOffsetY
            // 
            this.nudOffsetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudOffsetY.Location = new System.Drawing.Point(193, 318);
            this.nudOffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudOffsetY.Name = "nudOffsetY";
            this.nudOffsetY.Size = new System.Drawing.Size(116, 20);
            this.nudOffsetY.TabIndex = 17;
            this.nudOffsetY.ValueChanged += new System.EventHandler(this.nudOffsetY_ValueChanged);
            // 
            // nudOffsetX
            // 
            this.nudOffsetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudOffsetX.Location = new System.Drawing.Point(71, 318);
            this.nudOffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudOffsetX.Name = "nudOffsetX";
            this.nudOffsetX.Size = new System.Drawing.Size(116, 20);
            this.nudOffsetX.TabIndex = 16;
            this.nudOffsetX.ValueChanged += new System.EventHandler(this.nudOffsetX_ValueChanged);
            // 
            // cbPreferredColor
            // 
            this.cbPreferredColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPreferredColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPreferredColor.FormattingEnabled = true;
            this.cbPreferredColor.Location = new System.Drawing.Point(317, 317);
            this.cbPreferredColor.Name = "cbPreferredColor";
            this.cbPreferredColor.Size = new System.Drawing.Size(95, 21);
            this.cbPreferredColor.TabIndex = 19;
            this.cbPreferredColor.SelectedValueChanged += new System.EventHandler(this.cbPreferredColor_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sprite size:";
            // 
            // txtSpriteSize
            // 
            this.txtSpriteSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSpriteSize.Location = new System.Drawing.Point(71, 369);
            this.txtSpriteSize.Name = "txtSpriteSize";
            this.txtSpriteSize.ReadOnly = true;
            this.txtSpriteSize.Size = new System.Drawing.Size(116, 20);
            this.txtSpriteSize.TabIndex = 21;
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblX,
            this.lblXValue,
            this.lblY,
            this.lblYValue});
            this.ssStatus.Location = new System.Drawing.Point(0, 454);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(425, 22);
            this.ssStatus.TabIndex = 25;
            // 
            // lblX
            // 
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 17);
            this.lblX.Text = "X";
            // 
            // lblXValue
            // 
            this.lblXValue.AutoSize = false;
            this.lblXValue.Name = "lblXValue";
            this.lblXValue.Size = new System.Drawing.Size(22, 17);
            this.lblXValue.Text = "---";
            // 
            // lblY
            // 
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 17);
            this.lblY.Text = "Y";
            // 
            // lblYValue
            // 
            this.lblYValue.AutoSize = false;
            this.lblYValue.Name = "lblYValue";
            this.lblYValue.Size = new System.Drawing.Size(22, 17);
            this.lblYValue.Text = "---";
            // 
            // pbCaptureImage
            // 
            this.pbCaptureImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCaptureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCaptureImage.Location = new System.Drawing.Point(12, 12);
            this.pbCaptureImage.Name = "pbCaptureImage";
            this.pbCaptureImage.Size = new System.Drawing.Size(400, 300);
            this.pbCaptureImage.TabIndex = 0;
            this.pbCaptureImage.TabStop = false;
            this.pbCaptureImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDifferenceImage_Paint);
            this.pbCaptureImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDifferenceImage_MouseDown);
            this.pbCaptureImage.MouseLeave += new System.EventHandler(this.pbCaptureImage_MouseLeave);
            this.pbCaptureImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDifferenceImage_MouseMove);
            this.pbCaptureImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDifferenceImage_MouseUp);
            // 
            // cbSwapFrames
            // 
            this.cbSwapFrames.AutoSize = true;
            this.cbSwapFrames.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSwapFrames.Location = new System.Drawing.Point(325, 371);
            this.cbSwapFrames.Name = "cbSwapFrames";
            this.cbSwapFrames.Size = new System.Drawing.Size(87, 17);
            this.cbSwapFrames.TabIndex = 26;
            this.cbSwapFrames.Text = "Swap frames";
            this.cbSwapFrames.UseVisualStyleBackColor = true;
            this.cbSwapFrames.CheckedChanged += new System.EventHandler(this.cbSwapFrames_CheckedChanged);
            // 
            // CaptureForm
            // 
            this.AcceptButton = this.btnCollect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(425, 476);
            this.Controls.Add(this.cbSwapFrames);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.txtSpriteSize);
            this.Controls.Add(this.label1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(441, 473);
            this.Name = "CaptureForm";
            this.Text = "Select sprite...";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpriteSize;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblX;
        private System.Windows.Forms.ToolStripStatusLabel lblXValue;
        private System.Windows.Forms.ToolStripStatusLabel lblY;
        private System.Windows.Forms.ToolStripStatusLabel lblYValue;
        private System.Windows.Forms.CheckBox cbSwapFrames;
    }
}