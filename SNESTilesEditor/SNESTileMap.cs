using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNESTilesEditor
{
    public class SNESTileMap : ASNESVRAM
    {
        private List<SNESTile> tiles = new List<SNESTile>();

        private SNESPalette palette;

        private Image image;

        public SNESPalette Palette
        {
            get
            {
                return palette;
            }
        }

        public SNESTileMap(SNESPalette palette)
        {
            this.palette = palette;
        }

        public override byte[] VRAM
        {
            get
            {
                List<byte> ret = new List<byte>();
                foreach (SNESTile t in tiles)
                    ret.AddRange(t.VRAM);
                return ret.ToArray();
            }
            set
            {
                if ((value.Length % 64) == 0)
                {
                    tiles.Clear();
                    for (int i = 0, j; i < value.Length; i += 64)
                    {
                        SNESTile t = new SNESTile(this);
                        byte[] data = new byte[64];
                        for (j = 0; j < 64; j++)
                            data[j] = value[i + j];
                        t.VRAM = data;
                    }
                    image = null;
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
                    //ret = new Bitmap((tiles.Count < 16) ? (tiles.Count * 8) : 128, ((tiles.Count % 16) == 0) ? (tiles.Count / 16) : ((tiles.Count / 16) + 1));
                    ret = new Bitmap(128, ((tiles.Count / 16) + 1) * 8);
                    for (int i = 0, x, y; i < tiles.Count; i++)
                    {
                        Image im = tiles[i].Image;
                        Bitmap bm = (im is Bitmap) ? (Bitmap)im : (new Bitmap(im));
                        for (y = 0; y < 8; y++)
                        {
                            for (x = 0; x < 8; x++)
                                ret.SetPixel((i % 16) + x, (i / 16) + y, bm.GetPixel(x, y));
                        }
                    }
                    image = ret;
                }
                return ret;
            }
        }
    }
}
