using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNESTilesEditor
{
    public abstract class ASNESVRAM
    {
        public abstract byte[] VRAM
        {
            get;
            set;
        }

        public abstract Image Image
        {
            get;
        }

        public void LoadFile(string path)
        {
            try
            {
                using (FileStream fs = File.Open(path, FileMode.Open))
                {
                    byte[] data = new byte[fs.Length];
                    fs.Read(data, 0, data.Length);
                    VRAM = data;
                }
            }
            catch
            {
                //
            }
        }

        public void SaveFile(string path)
        {
            using (FileStream fs = File.Open(path, FileMode.Create))
            {
                byte[] data = VRAM;
                fs.Write(data, 0, data.Length);
            }
        }
    }
}
