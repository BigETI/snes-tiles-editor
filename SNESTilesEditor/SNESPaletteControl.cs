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

    public delegate void SelectedColorEvent(object sender, SelectedColorEventArgs e);

    public partial class SNESPaletteControl : UserControl
    {

        private SNESPalette palette = new SNESPalette();

        private int selectedIndex = 0;

        private bool focusNextTime = false;

        public event SelectedColorEvent SelectedColor;

        public SNESPalette Palette
        {
            get
            {
                return palette;
            }
        }

        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                if ((selectedIndex != value) && ((value >= 0) && (value < 0x100)))
                {
                    selectedIndex = value;
                    SelectedColor.Invoke(this, new SelectedColorEventArgs(selectedIndex, SNESColor));
                }
            }
        }

        public Image PaletteImage
        {
            get
            {
                Image ret = palette.Image;
                Bitmap bm = (ret is Bitmap) ? (Bitmap)ret : (new Bitmap(ret));
                bm = BitmapUtils.Upscale(bm, 16, 16);
                ret = bm;
                if (IsSelecting)
                {
                    int xmin = (selectedIndex % 16) * 16, xmax = ((selectedIndex % 16) * 16) + 15, ymin = (selectedIndex / 16) * 16, ymax = ((selectedIndex / 16) * 16) + 15;
                    Color sc = SNESColor.Color;
                    Color c = ((((sc.R > 0x7F) ? 1 : 0) + ((sc.G > 0x7F) ? 1 : 0) + ((sc.B > 0x7F) ? 1 : 0)) >= 2) ? Color.Black : Color.White;
                    
                    for (int j = 0, i; j < 4; j++)
                    {
                        for (i = 0; i < 4; i++)
                            bm.SetPixel(xmin + 6 + i, ymin + 6 + j, c);
                    }

                    for (int x = xmin; x <= xmax; x++)
                    {
                        bm.SetPixel(x, ymin, c);
                        bm.SetPixel(x, ymin + 1, c);
                        bm.SetPixel(x, ymax - 1, c);
                        bm.SetPixel(x, ymax, c);
                    }
                    ymax -= 2;
                    for (int y = ymin + 2; y <= ymax; y++)
                    {
                        bm.SetPixel(xmin, y, c);
                        bm.SetPixel(xmin + 1, y, c);
                        bm.SetPixel(xmax - 1, y, c);
                        bm.SetPixel(xmax, y, c);
                    }
                }
                return ret;
            }
        }

        public SNESColor SNESColor
        {
            get
            {
                return IsSelecting ? palette.Palette[selectedIndex] : (new SNESColor());
            }
            set
            {
                if ((value != null) && IsSelecting)
                {
                    palette.Palette[selectedIndex] = value;
                    palette.ReloadImage();
                    ReloadImage();
                }
            }
        }

        public bool IsSelecting
        {
            get
            {
                return ((selectedIndex >= 0) && (selectedIndex < 0x100));
            }
        }

        public SNESPaletteControl()
        {
            InitializeComponent();
            ReloadImage();
        }

        public void ReloadImage()
        {
            BackgroundImage = PaletteImage;
            Refresh();
            Focus();
        }

        private void SNESPaletteControl_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            SelectedIndex = ((me.Y / 16) * 16) + (me.X / 16) % 16;
            ReloadImage();
            Focus();
        }

        private void SNESPaletteControl_Leave(object sender, EventArgs e)
        {
            Focus();
            /*if (focusNextTime)
            {
                Focus();
                focusNextTime = false;
            }*/
        }

        private void SNESPaletteControl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (SelectedIndex >= 16)
                        SelectedIndex -= 16;
                    break;
                case Keys.Down:
                    if ((SelectedIndex + 16) < 0x100)
                        SelectedIndex += 16;
                    break;
                case Keys.Left:
                    if ((SelectedIndex % 16) != 0)
                        SelectedIndex--;
                    break;
                case Keys.Right:
                    if ((SelectedIndex % 16) != 15)
                        SelectedIndex++;
                    break;
            }
            focusNextTime = true;
            ReloadImage();
        }
    }
}
