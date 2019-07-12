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
            this.pbSprite = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSpriteBaseName = new System.Windows.Forms.TextBox();
            this.lblSpriteBaseName = new System.Windows.Forms.Label();
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
            this.lvSprites.LargeImageList = this.ilSprites;
            this.lvSprites.Location = new System.Drawing.Point(12, 12);
            this.lvSprites.Name = "lvSprites";
            this.lvSprites.Size = new System.Drawing.Size(215, 425);
            this.lvSprites.TabIndex = 0;
            this.lvSprites.UseCompatibleStateImageBehavior = false;
            this.lvSprites.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSprites_ItemSelectionChanged);
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
            this.btnClose.Location = new System.Drawing.Point(322, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(403, 443);
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
            this.tbZoom.Location = new System.Drawing.Point(771, 12);
            this.tbZoom.Minimum = 1;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbZoom.Size = new System.Drawing.Size(45, 425);
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
            this.txtSpriteBaseName.Location = new System.Drawing.Point(484, 445);
            this.txtSpriteBaseName.Name = "txtSpriteBaseName";
            this.txtSpriteBaseName.Size = new System.Drawing.Size(186, 20);
            this.txtSpriteBaseName.TabIndex = 5;
            // 
            // lblSpriteBaseName
            // 
            this.lblSpriteBaseName.AutoSize = true;
            this.lblSpriteBaseName.Location = new System.Drawing.Point(676, 448);
            this.lblSpriteBaseName.Name = "lblSpriteBaseName";
            this.lblSpriteBaseName.Size = new System.Drawing.Size(89, 13);
            this.lblSpriteBaseName.TabIndex = 6;
            this.lblSpriteBaseName.Text = "Sprite base name";
            // 
            // SpritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 475);
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
    }
}