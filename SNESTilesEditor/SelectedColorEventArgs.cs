using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNESTilesEditor
{
    public class SelectedColorEventArgs : EventArgs
    {
        private int selectedIndex;

        private SNESColor color;

        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
        }

        public SNESColor Color
        {
            get
            {
                return color;
            }
        }

        public SelectedColorEventArgs(int selectedIndex, SNESColor color)
        {
            this.selectedIndex = selectedIndex;
            this.color = color;
        }
    }
}
