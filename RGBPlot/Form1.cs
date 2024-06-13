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
using System.Drawing.Imaging;
using System.Diagnostics;
using Aspose.Cells;

namespace RGBPlot {
    public partial class Form1 : Form {
        
        public Form1() {
            InitializeComponent();
            InitPoints();
            Log("Initilaize completed");
        }

        void Log(string message) => Label_log.Text = message;

        public Point start, end;
        public Bitmap bitmap, linedBitmap ;
        (Point pos, Color color)[] colorData = new (Point pos, Color color)[100];
        public double scale, imageWidth;
        float ImageScale => (float)imageWidth / (float)bitmap.Width;
        bool IsPointSetted(bool outputLog = true) {
                if(start != end && bitmap != null) return true;
                if(outputLog)Log("Import Image and Set Ponts");
                return false;
        }

        public void SetImageWidthConfirm() => ImageWidthLabel.Text = "画像横幅: " + imageWidth.ToString("f2");

        private void DrawChart() {
            Log("Chart Drawing Started");
            ChartBox.ChartAreas.Clear();
            ChartBox.Series.Clear();
            var area = new ChartArea();
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = colorData.Length;
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 255;
            ChartBox.ChartAreas.Add(area);

            Series seriR = new Series() {
                Color = Color.Red,
                ChartType = SeriesChartType.Line,
                LegendText = "R"
            };
            Series seriB = new Series() {
                Color = Color.Blue,
                ChartType = SeriesChartType.Line,
                LegendText = "B"
            };
            Series seriG = new Series() {
                Color = Color.Green,
                ChartType = SeriesChartType.Line,
                LegendText = "G"
            };

            for (int i = 0; i < colorData.Length; i++){
                var c = colorData[i].color;
                seriR.Points.AddXY(i, c.R);
                seriB.Points.AddXY(i, c.B);
                seriG.Points.AddXY(i, c.G);
            }
            ChartBox.Series.Add(seriR);
            ChartBox.Series.Add(seriB);
            ChartBox.Series.Add(seriG);

            Log("Chart Drawing Completed");
        }

        void GetCopiedBitmap() {
            linedBitmap?.Dispose();
            double scale_x = (double)bitmap.Width / (double)PictureBox.Width;
            double scale_y = (double)bitmap.Height / (double)PictureBox.Height;
            scale = (scale_x > scale_y) ? scale_x : scale_y;
            var bmp = new Bitmap(bitmap, (int)(bitmap.Width / scale), (int)(bitmap.Height / scale));
            linedBitmap = new Bitmap(bmp, bmp.Width, bmp.Height);
            for (int x = 0; x < bmp.Width; x++) {
                for (int y = 0; y < bmp.Height; y++) {
                    linedBitmap.SetPixel(x, y, bmp.GetPixel(x, y));
                }
            }
            SetScaleLabel();
        }

        void SetScaleLabel() => ScaleLabel.Text = "拡大率: " + scale.ToString("f2");

        void SetStartPoint(Point point) {
            start = point;
            startPos.Text = start.ToString();
            SetStartBtn.Enabled = true;
            Log("Start Point was Setted");
        }

        void SetEndPoint(Point point) {
            end = point;
            endPos.Text = end.ToString();
            SetEndBtn.Enabled = true;
            Log("End Point was Setted");
        }

        void DrawLine() {
            GetCopiedBitmap();
            int xLen = end.X - start.X,
                yLen = end.Y - start.Y;
            float stepX = xLen / (float)colorData.Length,
                stepY = yLen / (float)colorData.Length;
            for (int i = 0; i < colorData.Length; i++) {
                var point = new Point((int)(start.X + i * stepX), (int)(start.Y + i * stepY));
                colorData[i] = (point, bitmap.GetPixel(point.X ,point.Y));
                point = (point.ToVector() / (float)scale).ToPoint();
                for (int j = 0; j < 9; j++){
                    var x = Math.Min(Math.Max(0, point.X + (j % 3) - 1), linedBitmap.Width - 1);
                    var y = Math.Min(Math.Max(0, point.Y + (j / 3) - 1), linedBitmap.Height - 1);
                    linedBitmap.SetPixel(x,y,Color.Red);
                }
            }
            PictureBox.Image = linedBitmap;
        }

        private void ChosePictureBtn_Click(object sender, EventArgs e) {
            Log("Openning FileDialog");
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Picture|*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    ImportImage(openFileDialog.FileName);
                }else Log("Canceled FileDialog");
            }
        }

        void ImportImage(string filePath) {
            if (filePath.EndsWith(".png") || filePath.EndsWith(".jpg") || filePath.EndsWith(".bmp")) {
                bitmap?.Dispose();
                using (var fs = new FileStream(filePath,
                         FileMode.Open,
                         FileAccess.Read)) {
                    bitmap = new Bitmap(fs);
                    this.filePath.Text = filePath;
                    fs.Dispose();
                    GetCopiedBitmap();
                    PictureBox.Image = linedBitmap;
                    InitPoints();
                    Log("Image File Opened");
                }
            } else {
                Log("jpg, png, bmp のみ受け付けます");
            }
        }

        void InitPoints() {
            SetStartPoint(default);
            SetEndPoint(default);
            SetImageWidthBtn.Enabled = false;
        }

        private void SetStartBtn_Click(object sender, EventArgs e) {
            if (bitmap == null || !SetEndBtn.Enabled) return;
            SetStartBtn.Enabled = false;
            Log("Chose Start Point");
        }

        private void SetEndBtn_Click(object sender, EventArgs e) {
            if (bitmap == null || !SetStartBtn.Enabled) return;
            SetEndBtn.Enabled = false;
            Log("Chose End Point");
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e) {
            if (linedBitmap is null || e.Location.X > linedBitmap.Width || e.Location.Y > linedBitmap.Height) return;
            var pos = (e.Location.ToVector() * (float)scale).ToPoint();
            Debug.WriteLine(pos);
            if (!SetStartBtn.Enabled) {
                SetStartPoint(pos);
            }
            if (!SetEndBtn.Enabled) {
                SetEndPoint(pos);
            }
            DrawLine();
            SetImageWidthBtn.Enabled = IsPointSetted(false);
        }

        private void PartitionCountBox_ValueChanged(object sender, EventArgs e) {
            int count = (int)PartitionCountBox.Value;
            if (count < 10) count = 10;
            if (count > 10000) count = 10000;
            PartitionCountBox.Value = count;
            colorData = new (Point pos, Color color)[count];
            if (IsPointSetted(false)) DrawLine();
        }

        private void SaveExcelFile_Click(object sender, EventArgs e) {
            if (!IsPointSetted()) return;
            SaveToExcel();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            ImportImage(files[0]);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.All;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e) {

        }

        private void SetImageWidthBtn_Click(object sender, EventArgs e) {
            new Form2(this).ShowDialog();
        }

        private void DrawChartBtn_Click(object sender, EventArgs e) {
            if (!IsPointSetted()) return;
            DrawChart();
        }

        void SaveToExcel() {
            Log("Creating Xlsx");
            Workbook wb = new Workbook();
            Worksheet sheet = wb.Worksheets[0];
            sheet.Cells["A1"].PutValue("X");
            sheet.Cells["B1"].PutValue("Y");
            sheet.Cells["D1"].PutValue("Color");
            sheet.Cells["E1"].PutValue("R");
            sheet.Cells["F1"].PutValue("G");
            sheet.Cells["G1"].PutValue("B");
            sheet.Cells["H1"].PutValue("H(色相)");
            sheet.Cells["I1"].PutValue("S(彩度)");
            sheet.Cells["J1"].PutValue("V(明度)");
            for (int i = 0; i < colorData.Length; i++){
                string index = (i + 2).ToString();
                var pos = (colorData[i].pos.ToVector() - colorData[0].pos.ToVector()) * ImageScale;
                var c = colorData[i].color;
                sheet.Cells["A" + index].PutValue(pos.X);
                sheet.Cells["B" + index].PutValue(pos.Y);
                sheet.Cells["E" + index].PutValue(c.R);
                sheet.Cells["F" + index].PutValue(c.G);
                sheet.Cells["G" + index].PutValue(c.B);
                sheet.Cells["H" + index].PutValue(c.GetHue());
                sheet.Cells["I" + index].PutValue(c.GetSaturation());
                sheet.Cells["J" + index].PutValue(c.GetBrightness());
            }
            wb.Save("ColorData.xlsx", SaveFormat.Xlsx);
            Log("Creating Xlsx Completed");
        }
    }
}
