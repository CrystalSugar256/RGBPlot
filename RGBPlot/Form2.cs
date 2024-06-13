using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBPlot {
    public partial class Form2 : Form {
        Form1 ins;
        public Form2(Form1 ins) {
            this.ins = ins;
            InitializeComponent();
        }

        double tempWidth;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            var dist = (ins.end.ToVector() - ins.start.ToVector()).Length();
            tempWidth = (int)numericUpDown1.Value / dist * ins.bitmap.Width;
            PictureWidthLabel.Text =  "画像横寸法: " + tempWidth.ToString("f2");
        }

        private void ConfirmBtn_Click(object sender, EventArgs e) {
            ins.imageWidth = tempWidth;
            ins.SetImageWidthConfirm();
            Close();
        }
    }
}
