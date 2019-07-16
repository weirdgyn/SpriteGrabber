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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpritesForm));
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
            resources.ApplyResources(this.ilSprites, "ilSprites");
            this.ilSprites.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvSprites
            // 
            resources.ApplyResources(this.lvSprites, "lvSprites");
            this.lvSprites.ContextMenuStrip = this.cmsSprites;
            this.lvSprites.LargeImageList = this.ilSprites;
            this.lvSprites.Name = "lvSprites";
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
            resources.ApplyResources(this.cmsSprites, "cmsSprites");
            this.cmsSprites.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSprites_Opening);
            // 
            // miClear
            // 
            this.miClear.Name = "miClear";
            resources.ApplyResources(this.miClear, "miClear");
            this.miClear.Click += new System.EventHandler(this.miClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            resources.ApplyResources(this.miDelete, "miDelete");
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // pbSprite
            // 
            resources.ApplyResources(this.pbSprite, "pbSprite");
            this.pbSprite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.TabStop = false;
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbZoom
            // 
            resources.ApplyResources(this.tbZoom, "tbZoom");
            this.tbZoom.Minimum = 1;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbZoom.Value = 1;
            this.tbZoom.Scroll += new System.EventHandler(this.tbZoom_Scroll);
            // 
            // fbdFolder
            // 
            resources.ApplyResources(this.fbdFolder, "fbdFolder");
            this.fbdFolder.RootFolder = System.Environment.SpecialFolder.MyPictures;
            // 
            // txtSpriteBaseName
            // 
            resources.ApplyResources(this.txtSpriteBaseName, "txtSpriteBaseName");
            this.txtSpriteBaseName.Name = "txtSpriteBaseName";
            // 
            // lblSpriteBaseName
            // 
            resources.ApplyResources(this.lblSpriteBaseName, "lblSpriteBaseName");
            this.lblSpriteBaseName.Name = "lblSpriteBaseName";
            // 
            // txtZoom
            // 
            resources.ApplyResources(this.txtZoom, "txtZoom");
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.ReadOnly = true;
            // 
            // SpritesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtZoom);
            this.Controls.Add(this.lblSpriteBaseName);
            this.Controls.Add(this.txtSpriteBaseName);
            this.Controls.Add(this.tbZoom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbSprite);
            this.Controls.Add(this.lvSprites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpritesForm";
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