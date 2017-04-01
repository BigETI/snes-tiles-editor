using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNESTilesEditor
{
    public partial class SNESPaletteEditor : UserControl
    {

        private SNESPalette palette = new SNESPalette();

        public SNESPalette Palette
        {
            get
            {
                return palette;
            }
        }

        public SNESPaletteEditor()
        {
            InitializeComponent();
        }
    }
}
