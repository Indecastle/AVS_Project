namespace AVS
{
    partial class Page_WMI
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_WMI));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbNameProc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuGauge5 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuGauge4 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuGauge3 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuGauge2 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuGauge1 = new Bunifu.Framework.UI.BunifuGauge();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbNameProc
            // 
            this.lbNameProc.AutoSize = true;
            this.lbNameProc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameProc.ForeColor = System.Drawing.Color.DimGray;
            this.lbNameProc.Location = new System.Drawing.Point(32, 192);
            this.lbNameProc.Name = "lbNameProc";
            this.lbNameProc.Size = new System.Drawing.Size(187, 32);
            this.lbNameProc.TabIndex = 8;
            this.lbNameProc.Text = "Processor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(578, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPU Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(122, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Core 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(308, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Core 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(494, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Core 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(680, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Core 4";
            // 
            // bunifuGauge5
            // 
            this.bunifuGauge5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuGauge5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge5.BackgroundImage")));
            this.bunifuGauge5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuGauge5.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuGauge5.Location = new System.Drawing.Point(629, 6);
            this.bunifuGauge5.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge5.Name = "bunifuGauge5";
            this.bunifuGauge5.ProgressBgColor = System.Drawing.Color.DarkGray;
            this.bunifuGauge5.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge5.ProgressColor2 = System.Drawing.Color.DarkRed;
            this.bunifuGauge5.Size = new System.Drawing.Size(135, 102);
            this.bunifuGauge5.TabIndex = 13;
            this.bunifuGauge5.Thickness = 20;
            this.bunifuGauge5.Value = 0;
            // 
            // bunifuGauge4
            // 
            this.bunifuGauge4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuGauge4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge4.BackgroundImage")));
            this.bunifuGauge4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuGauge4.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuGauge4.Location = new System.Drawing.Point(443, 6);
            this.bunifuGauge4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge4.Name = "bunifuGauge4";
            this.bunifuGauge4.ProgressBgColor = System.Drawing.Color.DarkGray;
            this.bunifuGauge4.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge4.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.bunifuGauge4.Size = new System.Drawing.Size(135, 102);
            this.bunifuGauge4.TabIndex = 12;
            this.bunifuGauge4.Thickness = 20;
            this.bunifuGauge4.Value = 0;
            // 
            // bunifuGauge3
            // 
            this.bunifuGauge3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuGauge3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge3.BackgroundImage")));
            this.bunifuGauge3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuGauge3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuGauge3.Location = new System.Drawing.Point(257, 6);
            this.bunifuGauge3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge3.Name = "bunifuGauge3";
            this.bunifuGauge3.ProgressBgColor = System.Drawing.Color.DarkGray;
            this.bunifuGauge3.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge3.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.bunifuGauge3.Size = new System.Drawing.Size(135, 102);
            this.bunifuGauge3.TabIndex = 11;
            this.bunifuGauge3.Thickness = 20;
            this.bunifuGauge3.Value = 0;
            // 
            // bunifuGauge2
            // 
            this.bunifuGauge2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuGauge2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge2.BackgroundImage")));
            this.bunifuGauge2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuGauge2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuGauge2.Location = new System.Drawing.Point(71, 6);
            this.bunifuGauge2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge2.Name = "bunifuGauge2";
            this.bunifuGauge2.ProgressBgColor = System.Drawing.Color.DarkGray;
            this.bunifuGauge2.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.bunifuGauge2.Size = new System.Drawing.Size(135, 102);
            this.bunifuGauge2.TabIndex = 10;
            this.bunifuGauge2.Thickness = 20;
            this.bunifuGauge2.Value = 0;
            // 
            // bunifuGauge1
            // 
            this.bunifuGauge1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge1.BackgroundImage")));
            this.bunifuGauge1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuGauge1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuGauge1.Location = new System.Drawing.Point(538, 145);
            this.bunifuGauge1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge1.Name = "bunifuGauge1";
            this.bunifuGauge1.ProgressBgColor = System.Drawing.Color.DarkGray;
            this.bunifuGauge1.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.bunifuGauge1.Size = new System.Drawing.Size(180, 120);
            this.bunifuGauge1.TabIndex = 1;
            this.bunifuGauge1.Thickness = 32;
            this.bunifuGauge1.Value = 0;
            // 
            // cpuChart
            // 
            this.cpuChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cpuChart.BorderlineColor = System.Drawing.Color.Red;
            this.cpuChart.BorderSkin.BackColor = System.Drawing.Color.Gainsboro;
            this.cpuChart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.cpuChart.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedHorizontal;
            this.cpuChart.BorderSkin.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cpuChart.BorderSkin.BorderColor = System.Drawing.Color.DimGray;
            chartArea2.Area3DStyle.WallWidth = 5;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            chartArea2.AxisX.Interval = 4D;
            chartArea2.AxisX.IsInterlaced = true;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.Interval = 4D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.MajorGrid.Interval = 10D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.cpuChart.Legends.Add(legend2);
            this.cpuChart.Location = new System.Drawing.Point(91, 302);
            this.cpuChart.Name = "cpuChart";
            this.cpuChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.LabelBorderColor = System.Drawing.Color.Red;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series2.MarkerColor = System.Drawing.Color.Maroon;
            series2.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.Name = "Series1";
            series2.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.DarkOliveGreen;
            series2.SmartLabelStyle.MaxMovingDistance = 100D;
            series2.YValuesPerPoint = 3;
            this.cpuChart.Series.Add(series2);
            this.cpuChart.Size = new System.Drawing.Size(730, 223);
            this.cpuChart.TabIndex = 18;
            this.cpuChart.Text = "chart1";
            // 
            // Page_WMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.cpuChart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuGauge5);
            this.Controls.Add(this.bunifuGauge4);
            this.Controls.Add(this.bunifuGauge3);
            this.Controls.Add(this.bunifuGauge2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNameProc);
            this.Controls.Add(this.bunifuGauge1);
            this.Name = "Page_WMI";
            this.Size = new System.Drawing.Size(896, 528);
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge1;
        private System.Windows.Forms.Label lbNameProc;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge2;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge3;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge4;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
    }
}
