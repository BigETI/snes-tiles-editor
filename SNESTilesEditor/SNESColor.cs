using System;
using System.Drawing;

namespace SNESTilesEditor
{
    public class SNESColor : ASNESVRAM
    {
        private byte r = 0;
        private byte g = 0;
        private byte b = 0;

        private Image image = null;

        public byte B
        {
            get
            {
                return b;
            }
            set
            {
                b = (byte)(value & 0x1F);
                image = null;
            }
        }

        public byte G
        {
            get
            {
                return g;
            }
            set
            {
                g = (byte)(value & 0x1F);
                image = null;
            }
        }

        public byte R
        {
            get
            {
                return r;
            }
            set
            {
                r = (byte)(value & 0x1F);
                image = null;
            }
        }

        public short BGR15
        {
            get
            {
                return (short)(r | (g << 5) | b << 10);
            }
            set
            {
                value &= 0x7FFF;
                r = (byte)(value & 0x1F);
                g = (byte)((value >> 5) & 0x1F);
                b = (byte)((value >> 10) & 0x1F);
                image = null;
            }
        }
        
        public int RGB24
        {
            get
            {
                return (int)((b * 255.0) / 30.0) | ((int)(((g * 255.0) / 30.0)) << 8) | ((int)(((r * 255.0) / 30.0)) << 16);
            }
            set
            {
                value &= 0xFFFFFF;
                r = (byte)((((value >> 16) & 0xFF) * 30.0) / 255.0);
                g = (byte)((((value >> 8) & 0xFF) * 30.0) / 255.0);
                b = (byte)(((value & 0xFF) * 30.0) / 255.0);
                image = null;
            }
        }

        public int ARGB32
        {
            get
            {
                return (int)(RGB24 | 0xFF000000);
            }
            set
            {
                r = (byte)((((value >> 16) & 0xFF) * 30.0) / 255.0);
                g = (byte)((((value >> 8) & 0xFF) * 30.0) / 255.0);
                b = (byte)(((value & 0xFF) * 30.0) / 255.0);
                image = null;
            }
        }

        public Color Color
        {
            get
            {
                return Color.FromArgb(ARGB32);
            }
            set
            {
                ARGB32 = value.ToArgb();
            }
        }

        public override byte[] VRAM
        {
            get
            {
                short c = BGR15;
                return new byte[] { (byte)(c & 0xFF), (byte)((c >> 8) & 0xFF) };
            }
            set
            {
                if (value != null)
                {
                    if (value.Length == 2)
                        BGR15 = (short)(value[0] | (value[1] << 8));
                }
            }
        }

        public override Image Image
        {
            get
            {
                Bitmap ret = (Bitmap)image;
                if (image == null)
                {
                    ret = new Bitmap(1, 1);
                    ret.SetPixel(0, 0, Color);
                    image = ret;
                }
                return ret;
            }
        }

        public SNESColor()
        {
            //
        }

        public SNESColor(SNESColor color)
        {
            r = color.r;
            g = color.g;
            b = color.b;
        }

        public SNESColor(Color color)
        {
            Color = color;
        }
    }
}
