namespace Emoji_2._0 {
    partial class Emoji {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emoji));
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picCats = new System.Windows.Forms.PictureBox();
            this.pnlKeyboard = new System.Windows.Forms.Panel();
            this.picKeyboard = new System.Windows.Forms.PictureBox();
            this.lblSkinColor = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotification = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).BeginInit();
            this.pnlKeyboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            this.cmsNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHide
            // 
            this.picHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picHide.Image = ((System.Drawing.Image)(resources.GetObject("picHide.Image")));
            this.picHide.Location = new System.Drawing.Point(580, 381);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(55, 55);
            this.picHide.TabIndex = 0;
            this.picHide.TabStop = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click);
            // 
            // picCats
            // 
            this.picCats.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picCats.Image = global::Emoji_2._0.Properties.Resources.type_0;
            this.picCats.Location = new System.Drawing.Point(39, 382);
            this.picCats.Name = "picCats";
            this.picCats.Size = new System.Drawing.Size(524, 54);
            this.picCats.TabIndex = 1;
            this.picCats.TabStop = false;
            this.picCats.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCats_MouseDown);
            // 
            // pnlKeyboard
            // 
            this.pnlKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKeyboard.AutoScroll = true;
            this.pnlKeyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(222)))));
            this.pnlKeyboard.Controls.Add(this.picKeyboard);
            this.pnlKeyboard.Location = new System.Drawing.Point(0, 59);
            this.pnlKeyboard.Name = "pnlKeyboard";
            this.pnlKeyboard.Size = new System.Drawing.Size(639, 317);
            this.pnlKeyboard.TabIndex = 2;
            // 
            // picKeyboard
            // 
            this.picKeyboard.Image = ((System.Drawing.Image)(resources.GetObject("picKeyboard.Image")));
            this.picKeyboard.Location = new System.Drawing.Point(0, 0);
            this.picKeyboard.Name = "picKeyboard";
            this.picKeyboard.Size = new System.Drawing.Size(2596, 300);
            this.picKeyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picKeyboard.TabIndex = 0;
            this.picKeyboard.TabStop = false;
            this.picKeyboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picKeyboard_MouseClick);
            // 
            // lblSkinColor
            // 
            this.lblSkinColor.AutoSize = true;
            this.lblSkinColor.BackColor = System.Drawing.Color.Transparent;
            this.lblSkinColor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkinColor.Location = new System.Drawing.Point(12, 22);
            this.lblSkinColor.Name = "lblSkinColor";
            this.lblSkinColor.Size = new System.Drawing.Size(78, 16);
            this.lblSkinColor.TabIndex = 3;
            this.lblSkinColor.Text = "Skin color:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picSettings
            // 
            this.picSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSettings.Image = global::Emoji_2._0.Properties.Resources.gear;
            this.picSettings.Location = new System.Drawing.Point(580, 2);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(55, 55);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSettings.TabIndex = 4;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.cmsNotification;
            this.notifyIcon.Text = "Emoji 2.0";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cmsNotification
            // 
            this.cmsNotification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShow,
            this.tsmExit});
            this.cmsNotification.Name = "cmsNotification";
            this.cmsNotification.Size = new System.Drawing.Size(104, 48);
            // 
            // tsmShow
            // 
            this.tsmShow.Name = "tsmShow";
            this.tsmShow.Size = new System.Drawing.Size(103, 22);
            this.tsmShow.Text = "Show";
            this.tsmShow.Click += new System.EventHandler(this.tsmShow_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(103, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // Emoji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 437);
            this.Controls.Add(this.picSettings);
            this.Controls.Add(this.lblSkinColor);
            this.Controls.Add(this.pnlKeyboard);
            this.Controls.Add(this.picCats);
            this.Controls.Add(this.picHide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(3000, 476);
            this.MinimumSize = new System.Drawing.Size(612, 250);
            this.Name = "Emoji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Emoji 2.0";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Emoji_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).EndInit();
            this.pnlKeyboard.ResumeLayout(false);
            this.pnlKeyboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            this.cmsNotification.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.PictureBox picCats;
        private System.Windows.Forms.Panel pnlKeyboard;
        private System.Windows.Forms.PictureBox picKeyboard;
        private System.Windows.Forms.Label lblSkinColor;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox picSettings;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmsNotification;
        private System.Windows.Forms.ToolStripMenuItem tsmShow;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;

    }
}

