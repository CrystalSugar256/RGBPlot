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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartBox = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PictureBox = new System.Windows.Forms.PictureBox();
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
            this.Label_distance = new System.Windows.Forms.Label();
            this.DistanceBox = new System.Windows.Forms.NumericUpDown();
            this.DistanceTypeSelecter = new System.Windows.Forms.ListBox();
            this.WidthBox = new System.Windows.Forms.NumericUpDown();
            this.Label_imageSize = new System.Windows.Forms.Label();
            this.Label_ScaleDesc = new System.Windows.Forms.Label();
            this.Label_Scale = new System.Windows.Forms.Label();
            this.SetWidthBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartitionCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartBox
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartBox.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartBox.Legends.Add(legend1);
            this.ChartBox.Location = new System.Drawing.Point(524, 12);
            this.ChartBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartBox.Name = "ChartBox";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartBox.Series.Add(series1);
            this.ChartBox.Size = new System.Drawing.Size(500, 300);
            this.ChartBox.TabIndex = 0;
            this.ChartBox.Text = "chart1";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(471, 300);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            // 
            // ChosePictureBtn
            // 
            this.ChosePictureBtn.Location = new System.Drawing.Point(12, 341);
            this.ChosePictureBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChosePictureBtn.Name = "ChosePictureBtn";
            this.ChosePictureBtn.Size = new System.Drawing.Size(123, 48);
            this.ChosePictureBtn.TabIndex = 2;
            this.ChosePictureBtn.Text = "ChosePicture";
            this.ChosePictureBtn.UseVisualStyleBackColor = true;
            this.ChosePictureBtn.Click += new System.EventHandler(this.ChosePictureBtn_Click);
            // 
            // SetStartBtn
            // 
            this.SetStartBtn.Location = new System.Drawing.Point(247, 341);
            this.SetStartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetStartBtn.Name = "SetStartBtn";
            this.SetStartBtn.Size = new System.Drawing.Size(81, 48);
            this.SetStartBtn.TabIndex = 3;
            this.SetStartBtn.Text = "StartPoint";
            this.SetStartBtn.UseVisualStyleBackColor = true;
            this.SetStartBtn.Click += new System.EventHandler(this.SetStartBtn_Click);
            // 
            // SetEndBtn
            // 
            this.SetEndBtn.Location = new System.Drawing.Point(403, 341);
            this.SetEndBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetEndBtn.Name = "SetEndBtn";
            this.SetEndBtn.Size = new System.Drawing.Size(81, 48);
            this.SetEndBtn.TabIndex = 4;
            this.SetEndBtn.Text = "EndPoint";
            this.SetEndBtn.UseVisualStyleBackColor = true;
            this.SetEndBtn.Click += new System.EventHandler(this.SetEndBtn_Click);
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Location = new System.Drawing.Point(12, 315);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(34, 15);
            this.filePath.TabIndex = 6;
            this.filePath.Text = "path";
            // 
            // startPos
            // 
            this.startPos.AutoSize = true;
            this.startPos.Location = new System.Drawing.Point(244, 392);
            this.startPos.Name = "startPos";
            this.startPos.Size = new System.Drawing.Size(43, 15);
            this.startPos.TabIndex = 7;
            this.startPos.Text = "label1";
            // 
            // endPos
            // 
            this.endPos.AutoSize = true;
            this.endPos.Location = new System.Drawing.Point(399, 392);
            this.endPos.Name = "endPos";
            this.endPos.Size = new System.Drawing.Size(43, 15);
            this.endPos.TabIndex = 8;
            this.endPos.Text = "label1";
            // 
            // DrawChartBtn
            // 
            this.DrawChartBtn.Location = new System.Drawing.Point(524, 341);
            this.DrawChartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawChartBtn.Name = "DrawChartBtn";
            this.DrawChartBtn.Size = new System.Drawing.Size(129, 48);
            this.DrawChartBtn.TabIndex = 9;
            this.DrawChartBtn.Text = "DrawChart";
            this.DrawChartBtn.UseVisualStyleBackColor = true;
            this.DrawChartBtn.Click += new System.EventHandler(this.DrawChartBtn_Click);
            // 
            // PartitionCountBox
            // 
            this.PartitionCountBox.Location = new System.Drawing.Point(683, 366);
            this.PartitionCountBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PartitionCountBox.Name = "PartitionCountBox";
            this.PartitionCountBox.Size = new System.Drawing.Size(120, 22);
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
            this.Lable_Partition.Location = new System.Drawing.Point(679, 348);
            this.Lable_Partition.Name = "Lable_Partition";
            this.Lable_Partition.Size = new System.Drawing.Size(52, 15);
            this.Lable_Partition.TabIndex = 11;
            this.Lable_Partition.Text = "分割数";
            // 
            // SaveExcelFile
            // 
            this.SaveExcelFile.Location = new System.Drawing.Point(831, 341);
            this.SaveExcelFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveExcelFile.Name = "SaveExcelFile";
            this.SaveExcelFile.Size = new System.Drawing.Size(107, 48);
            this.SaveExcelFile.TabIndex = 12;
            this.SaveExcelFile.Text = "SaveAs Xlsx";
            this.SaveExcelFile.UseVisualStyleBackColor = true;
            this.SaveExcelFile.Click += new System.EventHandler(this.SaveExcelFile_Click);
            // 
            // Label_log
            // 
            this.Label_log.AutoSize = true;
            this.Label_log.Location = new System.Drawing.Point(12, 430);
            this.Label_log.Name = "Label_log";
            this.Label_log.Size = new System.Drawing.Size(43, 15);
            this.Label_log.TabIndex = 13;
            this.Label_log.Text = "label1";
            // 
            // Label_distance
            // 
            this.Label_distance.AutoSize = true;
            this.Label_distance.Location = new System.Drawing.Point(247, 422);
            this.Label_distance.Name = "Label_distance";
            this.Label_distance.Size = new System.Drawing.Size(77, 15);
            this.Label_distance.TabIndex = 15;
            this.Label_distance.Text = "２点間距離";
            // 
            // DistanceBox
            // 
            this.DistanceBox.Location = new System.Drawing.Point(331, 422);
            this.DistanceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DistanceBox.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.DistanceBox.Name = "DistanceBox";
            this.DistanceBox.Size = new System.Drawing.Size(120, 22);
            this.DistanceBox.TabIndex = 16;
            // 
            // DistanceTypeSelecter
            // 
            this.DistanceTypeSelecter.FormattingEnabled = true;
            this.DistanceTypeSelecter.ItemHeight = 15;
            this.DistanceTypeSelecter.Items.AddRange(new object[] {
            "指定",
            "オート(要画像寸法)"});
            this.DistanceTypeSelecter.Location = new System.Drawing.Point(457, 422);
            this.DistanceTypeSelecter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DistanceTypeSelecter.Name = "DistanceTypeSelecter";
            this.DistanceTypeSelecter.Size = new System.Drawing.Size(129, 34);
            this.DistanceTypeSelecter.TabIndex = 17;
            this.DistanceTypeSelecter.SelectedIndexChanged += new System.EventHandler(this.DistanceTypeSelecter_SelectedIndexChanged);
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(152, 390);
            this.WidthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(63, 22);
            this.WidthBox.TabIndex = 18;
            // 
            // Label_imageSize
            // 
            this.Label_imageSize.AutoSize = true;
            this.Label_imageSize.Location = new System.Drawing.Point(12, 392);
            this.Label_imageSize.Name = "Label_imageSize";
            this.Label_imageSize.Size = new System.Drawing.Size(79, 15);
            this.Label_imageSize.TabIndex = 19;
            this.Label_imageSize.Text = "画像の横幅";
            // 
            // Label_ScaleDesc
            // 
            this.Label_ScaleDesc.AutoSize = true;
            this.Label_ScaleDesc.Location = new System.Drawing.Point(149, 341);
            this.Label_ScaleDesc.Name = "Label_ScaleDesc";
            this.Label_ScaleDesc.Size = new System.Drawing.Size(52, 15);
            this.Label_ScaleDesc.TabIndex = 20;
            this.Label_ScaleDesc.Text = "拡大率";
            // 
            // Label_Scale
            // 
            this.Label_Scale.AutoSize = true;
            this.Label_Scale.Location = new System.Drawing.Point(149, 358);
            this.Label_Scale.Name = "Label_Scale";
            this.Label_Scale.Size = new System.Drawing.Size(15, 15);
            this.Label_Scale.TabIndex = 21;
            this.Label_Scale.Text = "1";
            // 
            // SetWidthBtn
            // 
            this.SetWidthBtn.Location = new System.Drawing.Point(457, 461);
            this.SetWidthBtn.Name = "SetWidthBtn";
            this.SetWidthBtn.Size = new System.Drawing.Size(108, 23);
            this.SetWidthBtn.TabIndex = 22;
            this.SetWidthBtn.Text = "画像寸法逆算";
            this.SetWidthBtn.UseVisualStyleBackColor = true;
            this.SetWidthBtn.Click += new System.EventHandler(this.SetWidthBtn_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1036, 546);
            this.Controls.Add(this.SetWidthBtn);
            this.Controls.Add(this.Label_Scale);
            this.Controls.Add(this.Label_ScaleDesc);
            this.Controls.Add(this.Label_imageSize);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.DistanceTypeSelecter);
            this.Controls.Add(this.DistanceBox);
            this.Controls.Add(this.Label_distance);
            this.Controls.Add(this.Label_log);
            this.Controls.Add(this.SaveExcelFile);
            this.Controls.Add(this.Lable_Partition);
            this.Controls.Add(this.PartitionCountBox);
            this.Controls.Add(this.DrawChartBtn);
            this.Controls.Add(this.endPos);
            this.Controls.Add(this.startPos);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.SetEndBtn);
            this.Controls.Add(this.SetStartBtn);
            this.Controls.Add(this.ChosePictureBtn);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ChartBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.ChartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartitionCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBox;
        private System.Windows.Forms.PictureBox PictureBox;
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
        private System.Windows.Forms.Label Label_distance;
        private System.Windows.Forms.NumericUpDown DistanceBox;
        private System.Windows.Forms.ListBox DistanceTypeSelecter;
        private System.Windows.Forms.NumericUpDown WidthBox;
        private System.Windows.Forms.Label Label_imageSize;
        private System.Windows.Forms.Label Label_ScaleDesc;
        private System.Windows.Forms.Label Label_Scale;
        private System.Windows.Forms.Button SetWidthBtn;
    }
}

