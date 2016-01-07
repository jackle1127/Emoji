using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emoji_2._0 {
    public partial class FrmSettings : Form {
        public FrmSettings() {
            InitializeComponent();
            validateHidingRadio();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (rdoHideDown.Checked) Settings.hideMode = Settings.HIDE_DOWN;
            if (rdoHideFade.Checked) Settings.hideMode = Settings.HIDE_FADE;
            if (rdoHideLeft.Checked) Settings.hideMode = Settings.HIDE_LEFT;
            if (rdoHideNone.Checked) Settings.hideMode = Settings.HIDE_NO_ANIMATION;
            if (rdoHideRight.Checked) Settings.hideMode = Settings.HIDE_RIGHT;
            if (rdoHideUp.Checked) Settings.hideMode = Settings.HIDE_UP;
            Settings.save();
            Model.mainWindow.Show();
            this.Hide();
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e) {
            validateHidingRadio();
            this.Hide();
            Model.mainWindow.Show();
            e.Cancel = true;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            validateHidingRadio();
            Model.mainWindow.Show();
            this.Hide();
        }

        private void validateHidingRadio() {
            if (Settings.hideMode == Settings.HIDE_DOWN) rdoHideDown.Checked = true;
            if (Settings.hideMode == Settings.HIDE_FADE) rdoHideFade.Checked = true;
            if (Settings.hideMode == Settings.HIDE_LEFT) rdoHideLeft.Checked = true;
            if (Settings.hideMode == Settings.HIDE_NO_ANIMATION) rdoHideNone.Checked = true;
            if (Settings.hideMode == Settings.HIDE_UP) rdoHideUp.Checked = true;
        }
    }
}
