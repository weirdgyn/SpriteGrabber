namespace SpriteGrabber
{
    partial class SpritesForm
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
            this.components = new System.ComponentModel.Container();
            this.ilSprites = new System.Windows.Forms.ImageList(this.components);
            this.lvSprites = new System.Windows.Forms.ListView();
            this.cmsSprites = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.pbSprite = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSpriteBaseName = new System.Windows.Forms.TextBox();
            this.lblSpriteBaseName = new System.Windows.Forms.Label();
            this.txtZoom = new System.Windows.Forms.TextBox();
            this.cmsSprites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // ilSprites
            // 
            this.ilSprites.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ilSprites.ImageSize = new System.Drawing.Size(16, 16);
            this.ilSprites.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvSprites
            // 
            this.lvSprites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvSprites.ContextMenuStrip = this.cmsSprites;
            this.lvSprites.LargeImageList = this.ilSprites;
            this.lvSprites.Location = new System.Drawing.Point(12, 12);
            this.lvSprites.Name = "lvSprites";
            this.lvSprites.Size = new System.Drawing.Size(215, 425);
            this.lvSprites.TabIndex = 0;
            this.lvSprites.UseCompatibleStateImageBehavior = false;
            this.lvSprites.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSprites_ItemSelectionChanged);
            // 
            // cmsSprites
            // 
            this.cmsSprites.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClear,
            this.toolStripSeparator1,
            this.miDelete});
            this.cmsSprites.Name = "cmsSprites";
            this.cmsSprites.Size = new System.Drawing.Size(108, 54);
            this.cmsSprites.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSprites_Opening);
            // 
            // miClear
            // 
            this.miClear.Name = "miClear";
            this.miClear.Size = new System.Drawing.Size(107, 22);
            this.miClear.Text = "Clear";
            this.miClear.Click += new System.EventHandler(this.miClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(107, 22);
            this.miDelete.Text = "Delete";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // pbSprite
            // 
            this.pbSprite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSprite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSprite.Location = new System.Drawing.Point(233, 12);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(532, 425);
            this.pbSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSprite.TabIndex = 1;
            this.pbSprite.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(561, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(480, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbZoom
            // 
            this.tbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZoom.Location = new System.Drawing.Point(771, 38);
            this.tbZoom.Minimum = 1;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbZoom.Size = new System.Drawing.Size(45, 399);
            this.tbZoom.TabIndex = 4;
            this.tbZoom.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbZoom.Value = 1;
            this.tbZoom.Scroll += new System.EventHandler(this.tbZoom_Scroll);
            // 
            // fbdFolder
            // 
            this.fbdFolder.Description = "Select sprite collection destination folder";
            this.fbdFolder.RootFolder = System.Environment.SpecialFolder.MyPictures;
            // 
            // txtSpriteBaseName
            // 
            this.txtSpriteBaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSpriteBaseName.Location = new System.Drawing.Point(288, 444);
            this.txtSpriteBaseName.Name = "txtSpriteBaseName";
            this.txtSpriteBaseName.Size = new System.Drawing.Size(186, 20);
            this.txtSpriteBaseName.TabIndex = 5;
            this.txtSpriteBaseName.Text = "sprite";
            // 
            // lblSpriteBaseName
            // 
            this.lblSpriteBaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSpriteBaseName.AutoSize = true;
            this.lblSpriteBaseName.Location = new System.Drawing.Point(193, 448);
            this.lblSpriteBaseName.Name = "lblSpriteBaseName";
            this.lblSpriteBaseName.Size = new System.Drawing.Size(92, 13);
            this.lblSpriteBaseName.TabIndex = 6;
            this.lblSpriteBaseName.Text = "Sprite base name:";
            // 
            // txtZoom
            // 
            this.txtZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZoom.Location = new System.Drawing.Point(771, 12);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.ReadOnly = true;
            this.txtZoom.Size = new System.Drawing.Size(45, 20);
            this.txtZoom.TabIndex = 7;
            this.txtZoom.Text = "1";
            this.txtZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 475);
            this.Controls.Add(this.txtZoom);
            this.Controls.Add(this.lblSpriteBaseName);
            this.Controls.Add(this.txtSpriteBaseName);
            this.Controls.Add(this.tbZoom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbSprite);
            this.Controls.Add(this.lvSprites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpritesForm";
            this.Text = "Sprites";
            this.cmsSprites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ilSprites;
        private System.Windows.Forms.ListView lvSprites;
        private System.Windows.Forms.PictureBox pbSprite;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar tbZoom;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.TextBox txtSpriteBaseName;
        private System.Windows.Forms.Label lblSpriteBaseName;
        private System.Windows.Forms.ContextMenuStrip cmsSprites;
        private System.Windows.Forms.ToolStripMenuItem miClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.TextBox txtZoom;
    }
}