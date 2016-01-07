using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_2._0 {
    class Model {
        public static Emoji mainWindow;
        public static int race;
        public static int cat;
        public static char[] delimiterEach = { ' ' };
        public static String[] delimiterLine = { "\r\n" };
        public static String[][] emoji = new String[5][];
        public static String[] races;
        public static IntPtr hWnd;
        public static String oldClipboard;
        public static int mode = 0;

    }
}
