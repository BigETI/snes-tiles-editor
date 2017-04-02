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

        public SNESPaletteEditor()
        {
            InitializeComponent();
            paletteControl.SelectedColor += paletteControl_SelectedColor;
            ReloadImage();
        }

        public void ReloadImage()
        {
            SNESColor sc = paletteControl.SNESColor;
            selectedColorPanel.BackColor = sc.Color;
            colorSNESLabel.Text = "SNES: 0x" + sc.BGR15.ToString("X4");
            colorRGBLabel.Text = "RGB: 0x" + sc.RGB24.ToString("X6");
            selectedColorPanel.Refresh();
            colorSNESLabel.Refresh();
            colorRGBLabel.Refresh();
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            if (paletteControl.IsSelecting)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    paletteControl.SNESColor = new SNESColor(colorDialog.Color);
                    ReloadImage();
                }
            }
        }

        private void paletteControl_SelectedColor(object sender, SelectedColorEventArgs e)
        {
            ReloadImage();
        }
    }
}
