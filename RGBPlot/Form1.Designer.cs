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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.ChartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartitionCountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartBox
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartBox.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartBox.Legends.Add(legend2);
            this.ChartBox.Location = new System.Drawing.Point(524, 12);
            this.ChartBox.Name = "ChartBox";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartBox.Series.Add(series2);
            this.ChartBox.Size = new System.Drawing.Size(500, 300);
            this.ChartBox.TabIndex = 0;
            this.ChartBox.Text = "chart1";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(471, 300);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            // 
            // ChosePictureBtn
            // 
            this.ChosePictureBtn.Location = new System.Drawing.Point(12, 341);
            this.ChosePictureBtn.Name = "ChosePictureBtn";
            this.ChosePictureBtn.Size = new System.Drawing.Size(133, 48);
            this.ChosePictureBtn.TabIndex = 2;
            this.ChosePictureBtn.Text = "ChosePicture";
            this.ChosePictureBtn.UseVisualStyleBackColor = true;
            this.ChosePictureBtn.Click += new System.EventHandler(this.ChosePictureBtn_Click);
            // 
            // SetStartBtn
            // 
            this.SetStartBtn.Location = new System.Drawing.Point(247, 341);
            this.SetStartBtn.Name = "SetStartBtn";
            this.SetStartBtn.Size = new System.Drawing.Size(81, 48);
            this.SetStartBtn.TabIndex = 3;
            this.SetStartBtn.Text = "StartPoint";
            this.SetStartBtn.UseVisualStyleBackColor = true;
            this.SetStartBtn.Click += new System.EventHandler(this.SetStartBtn_Click);
            // 
            // SetEndBtn
            // 
            this.SetEndBtn.Location = new System.Drawing.Point(402, 341);
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
            this.DrawChartBtn.Name = "DrawChartBtn";
            this.DrawChartBtn.Size = new System.Drawing.Size(129, 48);
            this.DrawChartBtn.TabIndex = 9;
            this.DrawChartBtn.Text = "DrawChart";
            this.DrawChartBtn.UseVisualStyleBackColor = true;
            this.DrawChartBtn.Click += new System.EventHandler(this.DrawChartBtn_Click);
            // 
            // PartitionCountBox
            // 
            this.PartitionCountBox.Location = new System.Drawing.Point(682, 366);
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
            this.SaveExcelFile.Name = "SaveExcelFile";
            this.SaveExcelFile.Size = new System.Drawing.Size(107, 47);
            this.SaveExcelFile.TabIndex = 12;
            this.SaveExcelFile.Text = "SaveAs Xlsx";
            this.SaveExcelFile.UseVisualStyleBackColor = true;
            this.SaveExcelFile.Click += new System.EventHandler(this.SaveExcelFile_Click);
            // 
            // Label_log
            // 
            this.Label_log.AutoSize = true;
            this.Label_log.Location = new System.Drawing.Point(15, 417);
            this.Label_log.Name = "Label_log";
            this.Label_log.Size = new System.Drawing.Size(43, 15);
            this.Label_log.TabIndex = 13;
            this.Label_log.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 546);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ChartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartitionCountBox)).EndInit();
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
    }
}

