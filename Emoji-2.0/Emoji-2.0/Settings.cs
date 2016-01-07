using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_2._0 {
    class Settings {
        public static int hideMode = 1;
        public static int currentTop;
        public static int currentLeft;
        public static int currentHeight;
        public static int currentWidth;

        public const int HIDE_DOWN = 1;
        public const int HIDE_LEFT = 2;
        public const int HIDE_UP = 3;
        public const int HIDE_RIGHT = 4;
        public const int HIDE_FADE = 5;
        public const int HIDE_NO_ANIMATION = 6;

        public static void save() {
            if (Model.mode == 0) {
                Properties.Settings.Default.currentTop = currentTop;
                Properties.Settings.Default.currentLeft = currentLeft;
                Properties.Settings.Default.currentHeight = currentHeight;
                Properties.Settings.Default.currentWidth = currentWidth;
                Properties.Settings.Default.currentTop = currentTop;
                Properties.Settings.Default.hideMode = hideMode;
                Properties.Settings.Default.saved = true;
                Properties.Settings.Default.Save();
            }
        }

        public static void load() {
            currentTop = Properties.Settings.Default.currentTop;
            currentLeft = Properties.Settings.Default.currentLeft;
            currentHeight = Properties.Settings.Default.currentHeight;
            currentWidth = Properties.Settings.Default.currentWidth;
            currentTop = Properties.Settings.Default.currentTop;
            hideMode = Properties.Settings.Default.hideMode;
        }
    }
}