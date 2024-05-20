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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChosePicture = new System.Windows.Forms.Button();
            this.SetStart = new System.Windows.Forms.Button();
            this.SetEnd = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.Label();
            this.startPos = new System.Windows.Forms.Label();
            this.endPos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(524, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(500, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // ChosePicture
            // 
            this.ChosePicture.Location = new System.Drawing.Point(12, 341);
            this.ChosePicture.Name = "ChosePicture";
            this.ChosePicture.Size = new System.Drawing.Size(133, 48);
            this.ChosePicture.TabIndex = 2;
            this.ChosePicture.Text = "ChosePicture";
            this.ChosePicture.UseVisualStyleBackColor = true;
            this.ChosePicture.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetStart
            // 
            this.SetStart.Location = new System.Drawing.Point(247, 341);
            this.SetStart.Name = "SetStart";
            this.SetStart.Size = new System.Drawing.Size(81, 48);
            this.SetStart.TabIndex = 3;
            this.SetStart.Text = "StartPoint";
            this.SetStart.UseVisualStyleBackColor = true;
            this.SetStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // SetEnd
            // 
            this.SetEnd.Location = new System.Drawing.Point(402, 341);
            this.SetEnd.Name = "SetEnd";
            this.SetEnd.Size = new System.Drawing.Size(81, 48);
            this.SetEnd.TabIndex = 4;
            this.SetEnd.Text = "EndPoint";
            this.SetEnd.UseVisualStyleBackColor = true;
            this.SetEnd.Click += new System.EventHandler(this.button3_Click);
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Location = new System.Drawing.Point(12, 315);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(43, 15);
            this.filePath.TabIndex = 6;
            this.filePath.Text = "label2";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "DrawChart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endPos);
            this.Controls.Add(this.startPos);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.SetEnd);
            this.Controls.Add(this.SetStart);
            this.Controls.Add(this.ChosePicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ChosePicture;
        private System.Windows.Forms.Button SetStart;
        private System.Windows.Forms.Button SetEnd;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Label startPos;
        private System.Windows.Forms.Label endPos;
        private System.Windows.Forms.Button button1;
    }
}

