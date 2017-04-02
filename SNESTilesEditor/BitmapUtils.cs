using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNESTilesEditor
{
    public static class BitmapUtils
    {
        public static Bitmap Upscale(Bitmap bitmap, uint xTimes, uint yTimes)
        {
            Bitmap ret = null;
            if ((xTimes > 0U) && (yTimes > 0U))
            {
                ret = new Bitmap(bitmap.Width * (int)xTimes, bitmap.Height * (int)yTimes);
                for (int x, y = 0, xs, ys; y < bitmap.Height; y++)
                {
                    for (x = 0; x < bitmap.Width; x++)
                    {
                        Color c = bitmap.GetPixel(x, y);
                        for (ys = 0; ys < yTimes; ys++)
                        {
                            for (xs = 0; xs < xTimes; xs++)
                                ret.SetPixel((x * (int)xTimes) + xs, (y * (int)yTimes) + ys, c);
                        }
                    }
                }
            }
            else
                ret = new Bitmap(1, 1);
            return ret;
        }
    }
}
