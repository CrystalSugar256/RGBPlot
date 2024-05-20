using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;

namespace RGBPlot {
    public partial class Form1 : Form {
        public Bitmap bitmap;
        public Form1() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            SetStart.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e) {
            SetEnd.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PNG|*.png| JPEG|*.jpg*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;
                    bitmap?.Dispose();
                    using (var fs = new System.IO.FileStream(filePath,
                             System.IO.FileMode.Open,
                             System.IO.FileAccess.Read)) {
                        var bmp = new Bitmap(fs);
                        this.filePath.Text = filePath;
                        double scale_x = ((double)bmp.Width / (double)pictureBox1.Width);
                        double scale_y = ((double)bmp.Height / (double)pictureBox1.Height);
                        double scale = (scale_x > scale_y) ? scale_x : scale_y;

                        //リサイズ画像の作成
                        bitmap = new Bitmap(bmp, (int)(bmp.Width / scale), (int)(bmp.Height / scale));
                        bmp.Dispose();
                        fs.Dispose();
                        pictureBox1.Image = bitmap;
                    }
                }
            }
        }
        Point start, end;

        private void button1_Click_1(object sender, EventArgs e) {
            if(start == null || end == null || bitmap == null) return;
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            chart1.Legends.Clear();
            chart1.Dock = DockStyle.Fill;
            var area = new ChartArea();
            area.InnerPlotPosition.Width = 45f;
            area.InnerPlotPosition.Height = 50f;
            area.InnerPlotPosition.X = 50f;
            chart1.ChartAreas.Add(area);

            Series seriR = new Series() {
                Color = Color.Red,
                ChartType = SeriesChartType.Line
            };
            Series seriB = new Series() {
                Color = Color.Blue,
                ChartType = SeriesChartType.Line
            };
            Series seriG = new Series() {
                Color = Color.Green,
                ChartType = SeriesChartType.Line
            };
            float stepX = (end.X - start.X) / 100f,
                stepY = (end.Y - start.Y)/100f;
            for (int i = 0; i < 100; i++){
                seriR.Points.AddXY(i, bitmap.GetPixel(
                    (int)(start.X + i * stepX), (int)(start.Y + i * stepY)).R);
                seriB.Points.AddXY(i, bitmap.GetPixel(
                    (int)(start.X + i * stepX), (int)(start.Y + i * stepY)).B);
                seriG.Points.AddXY(i, bitmap.GetPixel(
                    (int)(start.X + i * stepX), (int)(start.Y + i * stepY)).G);
            }
            chart1.Series.Add(seriR);
            chart1.Series.Add(seriB);
            chart1.Series.Add(seriG);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e) {
            if (bitmap is null || e.Location.X > bitmap.Width || e.Location.Y > bitmap.Height) return;
            if (!SetStart.Enabled) {
                start = e.Location;
                startPos.Text = start.ToString();
                SetStart.Enabled = true;
            }
            if(!SetEnd.Enabled) {
                end = e.Location;
                endPos.Text = end.ToString();
                SetEnd.Enabled = true;
            }
        }
    }
}
