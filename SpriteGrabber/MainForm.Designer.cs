namespace SpriteGrabber
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbFrame1 = new System.Windows.Forms.PictureBox();
            this.pbFrame2 = new System.Windows.Forms.PictureBox();
            this.ofdDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtBundleFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.nudFrame1 = new System.Windows.Forms.NumericUpDown();
            this.lblFrame1 = new System.Windows.Forms.Label();
            this.lblFrame2 = new System.Windows.Forms.Label();
            this.nudFrame2 = new System.Windows.Forms.NumericUpDown();
            this.lvMessages = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMessages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miClear = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMessages = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.txtBGColor = new System.Windows.Forms.TextBox();
            this.lblBGColor = new System.Windows.Forms.Label();
            this.txtMaxFrames = new System.Windows.Forms.TextBox();
            this.lblMaxFrames = new System.Windows.Forms.Label();
            this.btnExchangeFrames = new System.Windows.Forms.Button();
            this.btnSprites = new System.Windows.Forms.Button();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrame2)).BeginInit();
            this.cmsMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFrame1
            // 
            this.pbFrame1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFrame1.Location = new System.Drawing.Point(11, 31);
            this.pbFrame1.Name = "pbFrame1";
            this.pbFrame1.Size = new System.Drawing.Size(400, 300);
            this.pbFrame1.TabIndex = 0;
            this.pbFrame1.TabStop = false;
            this.pbFrame1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFrame1_MouseDown);
            // 
            // pbFrame2
            // 
            this.pbFrame2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFrame2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFrame2.Location = new System.Drawing.Point(417, 31);
            this.pbFrame2.Name = "pbFrame2";
            this.pbFrame2.Size = new System.Drawing.Size(400, 300);
            this.pbFrame2.TabIndex = 1;
            this.pbFrame2.TabStop = false;
            this.pbFrame2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFrame2_MouseDown);
            // 
            // ofdDialog
            // 
            this.ofdDialog.DefaultExt = "*.mng";
            this.ofdDialog.Filter = "MNG picture bundle (*.mng)|*.mng|Video AVI (*.avi)|*.avi";
            this.ofdDialog.Title = "Select frames picture bundle";
            // 
            // txtBundleFile
            // 
            this.txtBundleFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBundleFile.Location = new System.Drawing.Point(91, 4);
            this.txtBundleFile.Name = "txtBundleFile";
            this.txtBundleFile.ReadOnly = true;
            this.txtBundleFile.Size = new System.Drawing.Size(696, 20);
            this.txtBundleFile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frames bundle:";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFile.Location = new System.Drawing.Point(794, 2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(25, 23);
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // nudFrame1
            // 
            this.nudFrame1.Location = new System.Drawing.Point(295, 337);
            this.nudFrame1.Name = "nudFrame1";
            this.nudFrame1.Size = new System.Drawing.Size(95, 20);
            this.nudFrame1.TabIndex = 6;
            this.nudFrame1.ValueChanged += new System.EventHandler(this.nudFrame1_ValueChanged);
            // 
            // lblFrame1
            // 
            this.lblFrame1.AutoSize = true;
            this.lblFrame1.Location = new System.Drawing.Point(250, 341);
            this.lblFrame1.Name = "lblFrame1";
            this.lblFrame1.Size = new System.Drawing.Size(36, 13);
            this.lblFrame1.TabIndex = 7;
            this.lblFrame1.Text = "Frame";
            // 
            // lblFrame2
            // 
            this.lblFrame2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrame2.AutoSize = true;
            this.lblFrame2.Location = new System.Drawing.Point(543, 341);
            this.lblFrame2.Name = "lblFrame2";
            this.lblFrame2.Size = new System.Drawing.Size(36, 13);
            this.lblFrame2.TabIndex = 9;
            this.lblFrame2.Text = "Frame";
            // 
            // nudFrame2
            // 
            this.nudFrame2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFrame2.Location = new System.Drawing.Point(436, 337);
            this.nudFrame2.Name = "nudFrame2";
            this.nudFrame2.Size = new System.Drawing.Size(101, 20);
            this.nudFrame2.TabIndex = 8;
            this.nudFrame2.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudFrame2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrame2.ValueChanged += new System.EventHandler(this.nudFrame2_ValueChanged);
            // 
            // lvMessages
            // 
            this.lvMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chMessage});
            this.lvMessages.ContextMenuStrip = this.cmsMessages;
            this.lvMessages.Location = new System.Drawing.Point(12, 432);
            this.lvMessages.Name = "lvMessages";
            this.lvMessages.Size = new System.Drawing.Size(806, 97);
            this.lvMessages.TabIndex = 10;
            this.lvMessages.UseCompatibleStateImageBehavior = false;
            this.lvMessages.View = System.Windows.Forms.View.Details;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            // 
            // chMessage
            // 
            this.chMessage.Text = "Message";
            // 
            // cmsMessages
            // 
            this.cmsMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSave,
            this.toolStripSeparator1,
            this.miClear});
            this.cmsMessages.Name = "cmsMessages";
            this.cmsMessages.Size = new System.Drawing.Size(102, 54);
            this.cmsMessages.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMessages_Opening);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(101, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(98, 6);
            // 
            // miClear
            // 
            this.miClear.Name = "miClear";
            this.miClear.Size = new System.Drawing.Size(101, 22);
            this.miClear.Text = "Clear";
            this.miClear.Click += new System.EventHandler(this.miClear_Click);
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(9, 416);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(58, 13);
            this.lblMessages.TabIndex = 11;
            this.lblMessages.Text = "Messages:";
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapture.Location = new System.Drawing.Point(370, 367);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(87, 23);
            this.btnCapture.TabIndex = 12;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtBGColor
            // 
            this.txtBGColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBGColor.Location = new System.Drawing.Point(718, 337);
            this.txtBGColor.Name = "txtBGColor";
            this.txtBGColor.ReadOnly = true;
            this.txtBGColor.Size = new System.Drawing.Size(98, 20);
            this.txtBGColor.TabIndex = 17;
            // 
            // lblBGColor
            // 
            this.lblBGColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBGColor.AutoSize = true;
            this.lblBGColor.Location = new System.Drawing.Point(660, 341);
            this.lblBGColor.Name = "lblBGColor";
            this.lblBGColor.Size = new System.Drawing.Size(52, 13);
            this.lblBGColor.TabIndex = 18;
            this.lblBGColor.Text = "BG Color:";
            // 
            // txtMaxFrames
            // 
            this.txtMaxFrames.Location = new System.Drawing.Point(56, 337);
            this.txtMaxFrames.Name = "txtMaxFrames";
            this.txtMaxFrames.ReadOnly = true;
            this.txtMaxFrames.Size = new System.Drawing.Size(46, 20);
            this.txtMaxFrames.TabIndex = 20;
            // 
            // lblMaxFrames
            // 
            this.lblMaxFrames.AutoSize = true;
            this.lblMaxFrames.Location = new System.Drawing.Point(11, 341);
            this.lblMaxFrames.Name = "lblMaxFrames";
            this.lblMaxFrames.Size = new System.Drawing.Size(44, 13);
            this.lblMaxFrames.TabIndex = 21;
            this.lblMaxFrames.Text = "Frames:";
            // 
            // btnExchangeFrames
            // 
            this.btnExchangeFrames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExchangeFrames.Location = new System.Drawing.Point(396, 335);
            this.btnExchangeFrames.Name = "btnExchangeFrames";
            this.btnExchangeFrames.Size = new System.Drawing.Size(34, 24);
            this.btnExchangeFrames.TabIndex = 22;
            this.btnExchangeFrames.Text = "<->";
            this.btnExchangeFrames.UseVisualStyleBackColor = true;
            this.btnExchangeFrames.Click += new System.EventHandler(this.btnExchangeFrames_Click);
            // 
            // btnSprites
            // 
            this.btnSprites.Location = new System.Drawing.Point(718, 363);
            this.btnSprites.Name = "btnSprites";
            this.btnSprites.Size = new System.Drawing.Size(98, 23);
            this.btnSprites.TabIndex = 23;
            this.btnSprites.Text = "Sprites";
            this.btnSprites.UseVisualStyleBackColor = true;
            this.btnSprites.Click += new System.EventHandler(this.btnSprites_Click);
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 2000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 541);
            this.Controls.Add(this.btnSprites);
            this.Controls.Add(this.btnExchangeFrames);
            this.Controls.Add(this.lblMaxFrames);
            this.Controls.Add(this.txtMaxFrames);
            this.Controls.Add(this.lblBGColor);
            this.Controls.Add(this.txtBGColor);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.lvMessages);
            this.Controls.Add(this.lblFrame2);
            this.Controls.Add(this.nudFrame2);
            this.Controls.Add(this.lblFrame1);
            this.Controls.Add(this.nudFrame1);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBundleFile);
            this.Controls.Add(this.pbFrame2);
            this.Controls.Add(this.pbFrame1);
            this.MinimumSize = new System.Drawing.Size(845, 580);
            this.Name = "MainForm";
            this.Text = "Sprite Grabber";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrame2)).EndInit();
            this.cmsMessages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFrame1;
        private System.Windows.Forms.PictureBox pbFrame2;
        private System.Windows.Forms.OpenFileDialog ofdDialog;
        private System.Windows.Forms.TextBox txtBundleFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.NumericUpDown nudFrame1;
        private System.Windows.Forms.Label lblFrame1;
        private System.Windows.Forms.Label lblFrame2;
        private System.Windows.Forms.NumericUpDown nudFrame2;
        private System.Windows.Forms.ListView lvMessages;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chMessage;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.TextBox txtBGColor;
        private System.Windows.Forms.Label lblBGColor;
        private System.Windows.Forms.TextBox txtMaxFrames;
        private System.Windows.Forms.Label lblMaxFrames;
        private System.Windows.Forms.Button btnExchangeFrames;
        private System.Windows.Forms.Button btnSprites;
        private System.Windows.Forms.ContextMenuStrip cmsMessages;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miClear;
        private System.Windows.Forms.Timer tmrSplash;
    }
}

