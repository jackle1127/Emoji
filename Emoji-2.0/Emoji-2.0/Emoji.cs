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
    public partial class Emoji : Form {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        bool ready = true;
        PictureBox[] races = new PictureBox[6];
        FrmSettings frmSettings;
        public Emoji() {
            InitializeComponent();
            this.ControlBox = false;
            if (!Properties.Settings.Default.saved) {
                this.Left = Screen.FromControl(this).Bounds.Width - this.Width;
                this.Top = Screen.FromControl(this).Bounds.Height - this.Height;
                updateSettings();
            } else {
                Settings.load();
                this.Top = Settings.currentTop;
                this.Left = Settings.currentLeft;
                this.Width = Settings.currentWidth;
                this.Height = Settings.currentHeight;
            }
            frmSettings = new FrmSettings();
            for (int i = 0; i < races.Length; i++) {
                races[i] = new PictureBox();
                races[i].SizeMode = PictureBoxSizeMode.AutoSize;
                races[i].Image = (Image) Properties.Resources.ResourceManager.GetObject("race_" + i);
                races[i].Top = 2;
                if (i == 0) {
                    races[i].Left = lblSkinColor.Left + lblSkinColor.Width + 5;
                } else {
                    races[i].Left = races[i - 1].Left + races[i - 1].Width + 5;
                }
                races[i].Tag = i;
                races[i].Click += (sender, e) => {
                    Model.race = (int) ((PictureBox) sender).Tag;
                    revalidateRace();
                };
                this.Controls.Add(races[i]);
            }
            notifyIcon.Icon = this.Icon;
            Model.race = 0;
            Model.cat = 0;
            Model.races = ((String)Properties.Resources.ResourceManager.GetObject("races")).Split(Model.delimiterEach);
            String[] potato = Model.races;
            revalidateRace();
            revalidateCat();
        }

        private void picCats_MouseDown(object sender, MouseEventArgs e) {
            Model.cat = e.X * 8 / picCats.Width;
            revalidateCat();
        }

        private void revalidateRace() {
            for (int i = 0; i < races.Length; i++) {
                if (i == Model.race) {
                    races[i].Image = (Image) Properties.Resources.ResourceManager.GetObject("race_" + i + "_s");
                } else {
                    races[i].Image = (Image) Properties.Resources.ResourceManager.GetObject("race_" + i);
                }
            }
        }

        private void revalidateCat() {
            picCats.Image = (Image) Properties.Resources.ResourceManager.GetObject("type_" + Model.cat);
            picKeyboard.Image = (Image) Properties.Resources.ResourceManager.GetObject("cat_" + Model.cat);
            String[] lines = ((String)Properties.Resources.ResourceManager.GetObject("catString_" + Model.cat)).Trim().Split(Model.delimiterLine, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < lines.Length; i++) {
                Model.emoji[i - 1] = lines[i].Split(Model.delimiterEach);
            }
        }

        private void picKeyboard_MouseClick(object sender, MouseEventArgs e) {
            if (ready) {
                int x = e.X * Model.emoji[0].Length / picKeyboard.Width;
                int y = e.Y * Model.emoji.Length / picKeyboard.Height;
                if (Model.emoji[y].Length > x) {
                    ready = false;
                    try {
                        String chosen = Model.emoji[y][x];
                        if (chosen.EndsWith("🏻")) {
                            chosen = chosen.Replace("🏻", Model.races[Model.race + 1]);
                        }
                        Model.oldClipboard = Clipboard.GetText();
                        SetForegroundWindow(Model.hWnd);
                        Clipboard.SetText(chosen);
                        SendKeys.SendWait("^V");
                        System.Threading.Thread.Sleep(120);
                        Clipboard.SetText(Model.oldClipboard);
                    } catch (Exception ex) { }
                    ready = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (!this.Focused && Model.mode == 0) {
                Model.hWnd = GetForegroundWindow();
            }
            animateHideShow();
        }

        private void picHide_Click(object sender, EventArgs e) {
            if (Model.mode == 0) {
                updateSettings();
                Settings.save();
            }
            if (Settings.hideMode != Settings.HIDE_NO_ANIMATION) {
                Model.mode = Settings.hideMode;
            } else {
                Model.mode = -10;
                this.Hide();
            }
        }

        private void animateHideShow() {
            if (Model.mode == Settings.HIDE_DOWN) {
                this.Top += 50;
                if (this.Top >= Screen.FromControl(this).Bounds.Height) {
                    Model.mode = -10;
                    this.Hide();
                }
            } else if (Model.mode == Settings.HIDE_LEFT) {
                this.Left -= 50;
                if (this.Left + this.Width <= 0) {
                    Model.mode = -10;
                    this.Hide();
                }
            } else if (Model.mode == Settings.HIDE_UP) {
                this.Top -= 50;
                if (this.Top + this.Height <= 0) {
                    Model.mode = -10;
                    this.Hide();
                }
            } else if (Model.mode == Settings.HIDE_RIGHT) {
                this.Left += 50;
                if (this.Left >= Screen.FromControl(this).Bounds.Width) {
                    Model.mode = -10;
                    this.Hide();
                }
            } else if (Model.mode == Settings.HIDE_FADE) {
                this.Opacity -= .05;
                if (this.Opacity <= 0) {
                    Model.mode = -10;
                    this.Hide();
                }
            } else if (Model.mode == -Settings.HIDE_DOWN) {
                this.Show();
                this.Top -= 50;
                if (this.Top <= Settings.currentTop) {
                    Model.mode = 0;
                }
            } else if (Model.mode == -Settings.HIDE_LEFT) {
                this.Show();
                this.Left += 50;
                if (this.Left >= Settings.currentLeft) {
                    Model.mode = 0;
                }
            } else if (Model.mode == -Settings.HIDE_UP) {
                this.Show();
                this.Top += 50;
                if (this.Top >= Settings.currentTop) {
                    Model.mode = 0;
                }
            } else if (Model.mode == -Settings.HIDE_RIGHT) {
                this.Show();
                this.Left -= 50;
                if (this.Left <= Settings.currentLeft) {
                    Model.mode = 0;
                }
            } else if (Model.mode == -Settings.HIDE_FADE) {
                this.Show();
                this.Opacity += .05;
                if (this.Opacity >= 1) {
                    Model.mode = 0;
                }
            }
            if (Model.mode == -10) {
                timer.Enabled = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            showWindow();
        }

        private void showWindow() {
            if (Model.mode != 0) {
                timer.Enabled = true;
                if (Settings.hideMode != Settings.HIDE_NO_ANIMATION) {
                    Model.mode = -Settings.hideMode;
                } else {
                    this.Show();
                    Model.mode = 0;
                }
            }
        }

        private void Emoji_FormClosing(object sender, FormClosingEventArgs e) {
            notifyIcon.Dispose();
            updateSettings();
            Settings.save();
        }

        private void updateSettings() {
            Settings.currentTop = this.Top;
            Settings.currentLeft = this.Left;
            Settings.currentWidth = this.Width;
            Settings.currentHeight = this.Height;
        }

        private void picSettings_Click(object sender, EventArgs e) {
            this.Hide();
            updateSettings();
            frmSettings.Show();
        }

        private void tsmExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void tsmShow_Click(object sender, EventArgs e) {
            showWindow();
        }
    }
}
