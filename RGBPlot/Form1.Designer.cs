namespace RGBPlot {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartBox = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChosePictureBtn = new System.Windows.Forms.Button();
            this.SetStartBtn = new System.Windows.Forms.Button();
            this.SetEndBtn = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.Label();
            this.startPos = new System.Windows.Forms.Label();
            this.endPos = new System.Windows.Forms.Label();
            this.DrawChartBtn = new System.Windows.Forms.Button();
            this.PartitionCountBox = new System.Windows.Forms.NumericUpDown();
            this.Lable_Partition = new System.Windows.Forms.Label();
            this.SaveExcelFile = new System.Windows.Forms.Button();
            this.Label_log = new System.Windows.Forms.Label();
            this.ImageWidthLabel = new System.Windows.Forms.Label();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.SetImageWidthBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartitionCountBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartBox
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartBox.ChartAreas.Add(chartArea3);
            this.ChartBox.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.ChartBox.Legends.Add(legend3);
            this.ChartBox.Location = new System.Drawing.Point(563, 2);
            this.ChartBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartBox.Name = "ChartBox";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartBox.Series.Add(series3);
            this.ChartBox.Size = new System.Drawing.Size(555, 290);
            this.ChartBox.TabIndex = 0;
            this.ChartBox.Text = "chart1";
            // 
            // ChosePictureBtn
            // 
            this.ChosePictureBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChosePictureBtn.Location = new System.Drawing.Point(3, 2);
            this.ChosePictureBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChosePictureBtn.Name = "ChosePictureBtn";
            this.ChosePictureBtn.Size = new System.Drawing.Size(154, 113);
            this.ChosePictureBtn.TabIndex = 2;
            this.ChosePictureBtn.Text = "ChosePicture";
            this.ChosePictureBtn.UseVisualStyleBackColor = true;
            this.ChosePictureBtn.Click += new System.EventHandler(this.ChosePictureBtn_Click);
            // 
            // SetStartBtn
            // 
            this.SetStartBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetStartBtn.Location = new System.Drawing.Point(323, 2);
            this.SetStartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetStartBtn.Name = "SetStartBtn";
            this.SetStartBtn.Size = new System.Drawing.Size(154, 113);
            this.SetStartBtn.TabIndex = 3;
            this.SetStartBtn.Text = "StartPoint";
            this.SetStartBtn.UseVisualStyleBackColor = true;
            this.SetStartBtn.Click += new System.EventHandler(this.SetStartBtn_Click);
            // 
            // SetEndBtn
            // 
            this.SetEndBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetEndBtn.Location = new System.Drawing.Point(483, 2);
            this.SetEndBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetEndBtn.Name = "SetEndBtn";
            this.SetEndBtn.Size = new System.Drawing.Size(154, 113);
            this.SetEndBtn.TabIndex = 4;
            this.SetEndBtn.Text = "EndPoint";
            this.SetEndBtn.UseVisualStyleBackColor = true;
            this.SetEndBtn.Click += new System.EventHandler(this.SetEndBtn_Click);
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePath.Location = new System.Drawing.Point(3, 300);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(1121, 30);
            this.filePath.TabIndex = 6;
            this.filePath.Text = "path";
            // 
            // startPos
            // 
            this.startPos.AutoSize = true;
            this.startPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPos.Location = new System.Drawing.Point(323, 117);
            this.startPos.Name = "startPos";
            this.startPos.Size = new System.Drawing.Size(154, 117);
            this.startPos.TabIndex = 7;
            this.startPos.Text = "label1";
            // 
            // endPos
            // 
            this.endPos.AutoSize = true;
            this.endPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endPos.Location = new System.Drawing.Point(483, 117);
            this.endPos.Name = "endPos";
            this.endPos.Size = new System.Drawing.Size(154, 117);
            this.endPos.TabIndex = 8;
            this.endPos.Text = "label1";
            // 
            // DrawChartBtn
            // 
            this.DrawChartBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawChartBtn.Location = new System.Drawing.Point(643, 2);
            this.DrawChartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawChartBtn.Name = "DrawChartBtn";
            this.DrawChartBtn.Size = new System.Drawing.Size(154, 113);
            this.DrawChartBtn.TabIndex = 9;
            this.DrawChartBtn.Text = "DrawChart";
            this.DrawChartBtn.UseVisualStyleBackColor = true;
            this.DrawChartBtn.Click += new System.EventHandler(this.DrawChartBtn_Click);
            // 
            // PartitionCountBox
            // 
            this.PartitionCountBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartitionCountBox.Location = new System.Drawing.Point(3, 57);
            this.PartitionCountBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PartitionCountBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PartitionCountBox.Name = "PartitionCountBox";
            this.PartitionCountBox.Size = new System.Drawing.Size(148, 22);
            this.PartitionCountBox.TabIndex = 10;
            this.PartitionCountBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PartitionCountBox.ValueChanged += new System.EventHandler(this.PartitionCountBox_ValueChanged);
            // 
            // Lable_Partition
            // 
            this.Lable_Partition.AutoSize = true;
            this.Lable_Partition.Cursor = System.Windows.Forms.Cursors.No;
            this.Lable_Partition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lable_Partition.Location = new System.Drawing.Point(3, 0);
            this.Lable_Partition.Name = "Lable_Partition";
            this.Lable_Partition.Size = new System.Drawing.Size(148, 55);
            this.Lable_Partition.TabIndex = 11;
            this.Lable_Partition.Text = "分割数";
            // 
            // SaveExcelFile
            // 
            this.SaveExcelFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveExcelFile.Location = new System.Drawing.Point(963, 2);
            this.SaveExcelFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveExcelFile.Name = "SaveExcelFile";
            this.SaveExcelFile.Size = new System.Drawing.Size(155, 113);
            this.SaveExcelFile.TabIndex = 12;
            this.SaveExcelFile.Text = "SaveAs Xlsx";
            this.SaveExcelFile.UseVisualStyleBackColor = true;
            this.SaveExcelFile.Click += new System.EventHandler(this.SaveExcelFile_Click);
            // 
            // Label_log
            // 
            this.Label_log.AutoSize = true;
            this.Label_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_log.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_log.Location = new System.Drawing.Point(3, 570);
            this.Label_log.Name = "Label_log";
            this.Label_log.Size = new System.Drawing.Size(1121, 30);
            this.Label_log.TabIndex = 13;
            this.Label_log.Text = "log";
            // 
            // ImageWidthLabel
            // 
            this.ImageWidthLabel.AutoSize = true;
            this.ImageWidthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageWidthLabel.Location = new System.Drawing.Point(3, 117);
            this.ImageWidthLabel.Name = "ImageWidthLabel";
            this.ImageWidthLabel.Size = new System.Drawing.Size(154, 117);
            this.ImageWidthLabel.TabIndex = 19;
            this.ImageWidthLabel.Text = "画像の横幅";
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScaleLabel.Location = new System.Drawing.Point(163, 0);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(154, 117);
            this.ScaleLabel.TabIndex = 20;
            this.ScaleLabel.Text = "拡大率";
            // 
            // SetImageWidthBtn
            // 
            this.SetImageWidthBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetImageWidthBtn.Location = new System.Drawing.Point(163, 120);
            this.SetImageWidthBtn.Name = "SetImageWidthBtn";
            this.SetImageWidthBtn.Size = new System.Drawing.Size(154, 111);
            this.SetImageWidthBtn.TabIndex = 21;
            this.SetImageWidthBtn.Text = "画像寸法指定";
            this.SetImageWidthBtn.UseVisualStyleBackColor = true;
            this.SetImageWidthBtn.Click += new System.EventHandler(this.SetImageWidthBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.filePath, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label_log, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 600);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PictureBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ChartBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1121, 294);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.ChosePictureBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ScaleLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.endPos, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.SetImageWidthBtn, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.startPos, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.SetStartBtn, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.ImageWidthLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.SetEndBtn, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.SaveExcelFile, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.DrawChartBtn, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 333);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1121, 234);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.Lable_Partition, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.PartitionCountBox, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(803, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(154, 111);
            this.tableLayoutPanel5.TabIndex = 25;
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(3, 2);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(554, 290);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1127, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.ChartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartitionCountBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBox;
        private System.Windows.Forms.Button ChosePictureBtn;
        private System.Windows.Forms.Button SetStartBtn;
        private System.Windows.Forms.Button SetEndBtn;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Label startPos;
        private System.Windows.Forms.Label endPos;
        private System.Windows.Forms.Button DrawChartBtn;
        private System.Windows.Forms.NumericUpDown PartitionCountBox;
        private System.Windows.Forms.Label Lable_Partition;
        private System.Windows.Forms.Button SaveExcelFile;
        private System.Windows.Forms.Label Label_log;
        private System.Windows.Forms.Label ImageWidthLabel;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.Button SetImageWidthBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

