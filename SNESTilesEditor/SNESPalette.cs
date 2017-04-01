using System;
using System.Collections.Generic;
using System.Drawing;

namespace SNESTilesEditor
{
    public class SNESPalette : ASNESVRAM
    {
        private SNESColor[] palette = new SNESColor[0x100];

        private Image image;

        public SNESColor[] Palette
        {
            get
            {
                return palette;
            }
        }

        public override byte[] VRAM
        {
            get
            {
                List<byte> ret = new List<byte>();
                foreach (SNESColor c in palette)
                {
                    foreach (byte b in c.VRAM)
                        ret.Add(b);
                }
                return ret.ToArray();
            }
            set
            {
                if (value != null)
                {
                    if (value.Length == 0x200)
                    {
                        for (int i = 0; i < palette.Length; i++)
                            palette[i].VRAM = new byte[] { value[i * 2], value[(i * 2) + 1] };
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
                    ret = new Bitmap(16, 16);
                    for (int i = 0; i < 0x100; i++)
                        ret.SetPixel(i % 8, i / 8, palette[i].Color);
                    image = ret;
                }
                return ret;
            }
        }

        public SNESPalette()
        {
            for (int i = 0; i < palette.Length; i++)
                palette[i] = new SNESColor();
        }
    }
}
