using System;
using System.Collections.Generic;
using System.Drawing;

namespace SNESTilesEditor
{
    public class SNESTile : ASNESVRAM
    {
        private SNESPalette palette;

        private short[] indicies = new short[64];

        private Image image = null;

        public SNESPalette Palette
        {
            get
            {
                return palette;
            }
            set
            {
                palette = value;
            }
        }

        public short[] Indicies
        {
            get
            {
                return (short[])(indicies.Clone());
            }
        }

        public override byte[] VRAM
        {
            get
            {
                List<byte> ret = new List<byte>();
                foreach (short i in indicies)
                {
                    ret.Add((byte)(i & 0xFF));
                    ret.Add((byte)((i >> 8) & 0xFF));
                }
                return ret.ToArray();
            }
            set
            {
                if (value != null)
                {
                    if (value.Length == 128)
                    {
                        for (int i = 0; i < indicies.Length; i++)
                            indicies[i] = (short)((value[i * 2]) | (value[(i * 2) + 1] << 8));
                    }
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
                    ret = new Bitmap(8, 8);
                    for (int i = 0; i < indicies.Length; i++)
                        ret.SetPixel(i % 8, i - (i % 8), palette.Palette[i].Color);
                    image = ret;
                }
                return ret;
            }
        }

        public SNESTile(SNESPalette palette)
        {
            this.palette = palette;
        }

        public void SetIndex(int x, int y, short index)
        {
            if ((x >= 0) && (x < 8) && (y >= 0) && (y < 8))
            {
                indicies[((x / y) * 8) + (x % 8)] = (index < 0x100) ? index : (short)0;
                image = null;
            }
        }
        
    }
}
