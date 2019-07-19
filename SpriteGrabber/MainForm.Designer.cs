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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbFrame1 = new System.Windows.Forms.PictureBox();
            this.pbFrame2 = new System.Windows.Forms.PictureBox();
            this.ofdDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtBundleFile = new System.Windows.Forms.TextBox();
            this.lblBundleFile = new System.Windows.Forms.Label();
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
            this.txtSprites = new System.Windows.Forms.TextBox();
            this.btnOptions = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.pbFrame1, "pbFrame1");
            this.pbFrame1.Name = "pbFrame1";
            this.pbFrame1.TabStop = false;
            this.pbFrame1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFrame1_MouseDown);
            // 
            // pbFrame2
            // 
            resources.ApplyResources(this.pbFrame2, "pbFrame2");
            this.pbFrame2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFrame2.Name = "pbFrame2";
            this.pbFrame2.TabStop = false;
            this.pbFrame2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFrame2_MouseDown);
            // 
            // ofdDialog
            // 
            this.ofdDialog.DefaultExt = "mng";
            resources.ApplyResources(this.ofdDialog, "ofdDialog");
            // 
            // txtBundleFile
            // 
            this.txtBundleFile.AllowDrop = true;
            resources.ApplyResources(this.txtBundleFile, "txtBundleFile");
            this.txtBundleFile.Name = "txtBundleFile";
            this.txtBundleFile.ReadOnly = true;
            this.txtBundleFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtBundleFile_DragDrop);
            this.txtBundleFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtBundleFile_DragEnter);
            // 
            // lblBundleFile
            // 
            resources.ApplyResources(this.lblBundleFile, "lblBundleFile");
            this.lblBundleFile.Name = "lblBundleFile";
            // 
            // btnSelectFile
            // 
            resources.ApplyResources(this.btnSelectFile, "btnSelectFile");
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // nudFrame1
            // 
            resources.ApplyResources(this.nudFrame1, "nudFrame1");
            this.nudFrame1.Name = "nudFrame1";
            this.nudFrame1.ValueChanged += new System.EventHandler(this.nudFrame1_ValueChanged);
            // 
            // lblFrame1
            // 
            resources.ApplyResources(this.lblFrame1, "lblFrame1");
            this.lblFrame1.Name = "lblFrame1";
            // 
            // lblFrame2
            // 
            resources.ApplyResources(this.lblFrame2, "lblFrame2");
            this.lblFrame2.Name = "lblFrame2";
            // 
            // nudFrame2
            // 
            resources.ApplyResources(this.nudFrame2, "nudFrame2");
            this.nudFrame2.Name = "nudFrame2";
            this.nudFrame2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrame2.ValueChanged += new System.EventHandler(this.nudFrame2_ValueChanged);
            // 
            // lvMessages
            // 
            resources.ApplyResources(this.lvMessages, "lvMessages");
            this.lvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chMessage});
            this.lvMessages.ContextMenuStrip = this.cmsMessages;
            this.lvMessages.Name = "lvMessages";
            this.lvMessages.UseCompatibleStateImageBehavior = false;
            this.lvMessages.View = System.Windows.Forms.View.Details;
            // 
            // chTime
            // 
            resources.ApplyResources(this.chTime, "chTime");
            // 
            // chMessage
            // 
            resources.ApplyResources(this.chMessage, "chMessage");
            // 
            // cmsMessages
            // 
            this.cmsMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSave,
            this.toolStripSeparator1,
            this.miClear});
            this.cmsMessages.Name = "cmsMessages";
            resources.ApplyResources(this.cmsMessages, "cmsMessages");
            this.cmsMessages.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMessages_Opening);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            resources.ApplyResources(this.miSave, "miSave");
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // miClear
            // 
            this.miClear.Name = "miClear";
            resources.ApplyResources(this.miClear, "miClear");
            this.miClear.Click += new System.EventHandler(this.miClear_Click);
            // 
            // lblMessages
            // 
            resources.ApplyResources(this.lblMessages, "lblMessages");
            this.lblMessages.Name = "lblMessages";
            // 
            // btnCapture
            // 
            resources.ApplyResources(this.btnCapture, "btnCapture");
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtBGColor
            // 
            resources.ApplyResources(this.txtBGColor, "txtBGColor");
            this.txtBGColor.Name = "txtBGColor";
            this.txtBGColor.ReadOnly = true;
            // 
            // lblBGColor
            // 
            resources.ApplyResources(this.lblBGColor, "lblBGColor");
            this.lblBGColor.Name = "lblBGColor";
            // 
            // txtMaxFrames
            // 
            resources.ApplyResources(this.txtMaxFrames, "txtMaxFrames");
            this.txtMaxFrames.Name = "txtMaxFrames";
            this.txtMaxFrames.ReadOnly = true;
            // 
            // lblMaxFrames
            // 
            resources.ApplyResources(this.lblMaxFrames, "lblMaxFrames");
            this.lblMaxFrames.Name = "lblMaxFrames";
            // 
            // btnExchangeFrames
            // 
            resources.ApplyResources(this.btnExchangeFrames, "btnExchangeFrames");
            this.btnExchangeFrames.Name = "btnExchangeFrames";
            this.btnExchangeFrames.UseVisualStyleBackColor = true;
            this.btnExchangeFrames.Click += new System.EventHandler(this.btnExchangeFrames_Click);
            // 
            // btnSprites
            // 
            resources.ApplyResources(this.btnSprites, "btnSprites");
            this.btnSprites.Name = "btnSprites";
            this.btnSprites.UseVisualStyleBackColor = true;
            this.btnSprites.Click += new System.EventHandler(this.btnSprites_Click);
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 2000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // txtSprites
            // 
            resources.ApplyResources(this.txtSprites, "txtSprites");
            this.txtSprites.Name = "txtSprites";
            this.txtSprites.ReadOnly = true;
            // 
            // btnOptions
            // 
            resources.ApplyResources(this.btnOptions, "btnOptions");
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.txtSprites);
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
            this.Controls.Add(this.lblBundleFile);
            this.Controls.Add(this.txtBundleFile);
            this.Controls.Add(this.pbFrame2);
            this.Controls.Add(this.pbFrame1);
            this.Name = "MainForm";
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
        private System.Windows.Forms.Label lblBundleFile;
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
        private System.Windows.Forms.TextBox txtSprites;
        private System.Windows.Forms.Button btnOptions;
    }
}

