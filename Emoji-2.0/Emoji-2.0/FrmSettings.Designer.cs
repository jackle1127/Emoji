namespace Emoji_2._0 {
    partial class FrmSettings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.rdoHideLeft = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoHideNone = new System.Windows.Forms.RadioButton();
            this.rdoHideFade = new System.Windows.Forms.RadioButton();
            this.rdoHideRight = new System.Windows.Forms.RadioButton();
            this.rdoHideDown = new System.Windows.Forms.RadioButton();
            this.rdoHideUp = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoHideLeft
            // 
            this.rdoHideLeft.AutoSize = true;
            this.rdoHideLeft.Location = new System.Drawing.Point(6, 61);
            this.rdoHideLeft.Name = "rdoHideLeft";
            this.rdoHideLeft.Size = new System.Drawing.Size(43, 17);
            this.rdoHideLeft.TabIndex = 1;
            this.rdoHideLeft.Text = "Left";
            this.rdoHideLeft.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoHideNone);
            this.groupBox1.Controls.Add(this.rdoHideFade);
            this.groupBox1.Controls.Add(this.rdoHideRight);
            this.groupBox1.Controls.Add(this.rdoHideDown);
            this.groupBox1.Controls.Add(this.rdoHideUp);
            this.groupBox1.Controls.Add(this.rdoHideLeft);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiding Animation";
            // 
            // rdoHideNone
            // 
            this.rdoHideNone.AutoSize = true;
            this.rdoHideNone.Location = new System.Drawing.Point(6, 139);
            this.rdoHideNone.Name = "rdoHideNone";
            this.rdoHideNone.Size = new System.Drawing.Size(51, 17);
            this.rdoHideNone.TabIndex = 5;
            this.rdoHideNone.Text = "None";
            this.rdoHideNone.UseVisualStyleBackColor = true;
            // 
            // rdoHideFade
            // 
            this.rdoHideFade.AutoSize = true;
            this.rdoHideFade.Location = new System.Drawing.Point(135, 61);
            this.rdoHideFade.Name = "rdoHideFade";
            this.rdoHideFade.Size = new System.Drawing.Size(49, 17);
            this.rdoHideFade.TabIndex = 2;
            this.rdoHideFade.Text = "Fade";
            this.rdoHideFade.UseVisualStyleBackColor = true;
            // 
            // rdoHideRight
            // 
            this.rdoHideRight.AutoSize = true;
            this.rdoHideRight.Location = new System.Drawing.Point(272, 61);
            this.rdoHideRight.Name = "rdoHideRight";
            this.rdoHideRight.Size = new System.Drawing.Size(50, 17);
            this.rdoHideRight.TabIndex = 3;
            this.rdoHideRight.Text = "Right";
            this.rdoHideRight.UseVisualStyleBackColor = true;
            // 
            // rdoHideDown
            // 
            this.rdoHideDown.AutoSize = true;
            this.rdoHideDown.Checked = true;
            this.rdoHideDown.Location = new System.Drawing.Point(135, 103);
            this.rdoHideDown.Name = "rdoHideDown";
            this.rdoHideDown.Size = new System.Drawing.Size(53, 17);
            this.rdoHideDown.TabIndex = 4;
            this.rdoHideDown.TabStop = true;
            this.rdoHideDown.Text = "Down";
            this.rdoHideDown.UseVisualStyleBackColor = true;
            // 
            // rdoHideUp
            // 
            this.rdoHideUp.AutoSize = true;
            this.rdoHideUp.Location = new System.Drawing.Point(135, 19);
            this.rdoHideUp.Name = "rdoHideUp";
            this.rdoHideUp.Size = new System.Drawing.Size(39, 17);
            this.rdoHideUp.TabIndex = 0;
            this.rdoHideUp.Text = "Up";
            this.rdoHideUp.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(268, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(12, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 222);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoHideLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoHideRight;
        private System.Windows.Forms.RadioButton rdoHideDown;
        private System.Windows.Forms.RadioButton rdoHideUp;
        private System.Windows.Forms.RadioButton rdoHideNone;
        private System.Windows.Forms.RadioButton rdoHideFade;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}