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
            this.pbCaptureImage = new System.Windows.Forms.PictureBox();
            this.sfdDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblSprite = new System.Windows.Forms.Label();
            this.txtSpriteFile = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCollect = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.lblOffset = new System.Windows.Forms.Label();
            this.nudOffsetY = new System.Windows.Forms.NumericUpDown();
            this.nudOffsetX = new System.Windows.Forms.NumericUpDown();
            this.cbPreferredColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpriteSize = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptureImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetX)).BeginInit();
            this.SuspendLayout();
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
            // sfdDialog
            // 
            this.sfdDialog.DefaultExt = "*.png";
            this.sfdDialog.Filter = "PNG image file *.png|*.png";
            // 
            // lblSprite
            // 
            this.lblSprite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSprite.AutoSize = true;
            this.lblSprite.Location = new System.Drawing.Point(14, 348);
            this.lblSprite.Name = "lblSprite";
            this.lblSprite.Size = new System.Drawing.Size(53, 13);
            this.lblSprite.TabIndex = 1;
            this.lblSprite.Text = "Sprite file:";
            // 
            // txtSpriteFile
            // 
            this.txtSpriteFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpriteFile.Location = new System.Drawing.Point(73, 344);
            this.txtSpriteFile.Name = "txtSpriteFile";
            this.txtSpriteFile.ReadOnly = true;
            this.txtSpriteFile.Size = new System.Drawing.Size(279, 20);
            this.txtSpriteFile.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(358, 343);
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
            this.btnCollect.Location = new System.Drawing.Point(134, 404);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(75, 23);
            this.btnCollect.TabIndex = 4;
            this.btnCollect.Text = "Collect";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiscard.Location = new System.Drawing.Point(215, 404);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(75, 23);
            this.btnDiscard.TabIndex = 5;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(15, 322);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(38, 13);
            this.lblOffset.TabIndex = 18;
            this.lblOffset.Text = "Offset:";
            // 
            // nudOffsetY
            // 
            this.nudOffsetY.Location = new System.Drawing.Point(195, 318);
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
            this.nudOffsetX.Location = new System.Drawing.Point(73, 318);
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sprite size:";
            // 
            // txtSpriteSize
            // 
            this.txtSpriteSize.Location = new System.Drawing.Point(73, 369);
            this.txtSpriteSize.Name = "txtSpriteSize";
            this.txtSpriteSize.ReadOnly = true;
            this.txtSpriteSize.Size = new System.Drawing.Size(116, 20);
            this.txtSpriteSize.TabIndex = 21;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(332, 282);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(32, 20);
            this.txtX.TabIndex = 23;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(370, 282);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(32, 20);
            this.txtY.TabIndex = 24;
            // 
            // CaptureForm
            // 
            this.AcceptButton = this.btnCollect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDiscard;
            this.ClientSize = new System.Drawing.Size(425, 434);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtSpriteSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPreferredColor);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.nudOffsetY);
            this.Controls.Add(this.nudOffsetX);
            this.Controls.Add(this.btnDiscard);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptureImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetX)).EndInit();
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
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.NumericUpDown nudOffsetY;
        private System.Windows.Forms.NumericUpDown nudOffsetX;
        private System.Windows.Forms.ComboBox cbPreferredColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpriteSize;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
    }
}