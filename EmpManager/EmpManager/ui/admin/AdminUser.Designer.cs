namespace winform1219.ui.admin
{
    partial class AdminUser
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.uiBarChart = new Sunny.UI.UIBarChart();
            this.uiPieChart = new Sunny.UI.UIPieChart();
            this.uiDouChart = new Sunny.UI.UIDoughnutChart();
            this.formChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.formChart)).BeginInit();
            this.SuspendLayout();
            // 
            // uiBarChart
            // 
            this.uiBarChart.BackColor = System.Drawing.Color.Transparent;
            this.uiBarChart.FillColor = System.Drawing.Color.Transparent;
            this.uiBarChart.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiBarChart.LegendFont = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.uiBarChart.Location = new System.Drawing.Point(18, 150);
            this.uiBarChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBarChart.Name = "uiBarChart";
            this.uiBarChart.RectColor = System.Drawing.Color.Transparent;
            this.uiBarChart.Size = new System.Drawing.Size(322, 262);
            this.uiBarChart.Style = Sunny.UI.UIStyle.Custom;
            this.uiBarChart.SubFont = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.uiBarChart.TabIndex = 0;
            this.uiBarChart.Text = "연령 정보";
            this.uiBarChart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPieChart
            // 
            this.uiPieChart.BackColor = System.Drawing.Color.Transparent;
            this.uiPieChart.FillColor = System.Drawing.Color.Transparent;
            this.uiPieChart.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPieChart.LegendFont = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.uiPieChart.Location = new System.Drawing.Point(346, 150);
            this.uiPieChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPieChart.Name = "uiPieChart";
            this.uiPieChart.RectColor = System.Drawing.Color.Transparent;
            this.uiPieChart.Size = new System.Drawing.Size(322, 262);
            this.uiPieChart.Style = Sunny.UI.UIStyle.Custom;
            this.uiPieChart.SubFont = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.uiPieChart.TabIndex = 1;
            this.uiPieChart.Text = "나이 정보";
            this.uiPieChart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDouChart
            // 
            this.uiDouChart.BackColor = System.Drawing.Color.Transparent;
            this.uiDouChart.FillColor = System.Drawing.Color.Transparent;
            this.uiDouChart.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDouChart.LegendFont = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.uiDouChart.Location = new System.Drawing.Point(18, 435);
            this.uiDouChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiDouChart.Name = "uiDouChart";
            this.uiDouChart.RectColor = System.Drawing.Color.Transparent;
            this.uiDouChart.Size = new System.Drawing.Size(322, 262);
            this.uiDouChart.Style = Sunny.UI.UIStyle.Custom;
            this.uiDouChart.SubFont = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.uiDouChart.TabIndex = 2;
            this.uiDouChart.Text = "나이 정보";
            this.uiDouChart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // formChart
            // 
            this.formChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.formChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.formChart.Legends.Add(legend1);
            this.formChart.Location = new System.Drawing.Point(346, 435);
            this.formChart.Name = "formChart";
            this.formChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "급여";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "상여금";
            this.formChart.Series.Add(series1);
            this.formChart.Series.Add(series2);
            this.formChart.Size = new System.Drawing.Size(322, 262);
            this.formChart.TabIndex = 3;
            this.formChart.Text = "chart1";
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine1.Location = new System.Drawing.Point(56, 99);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(580, 2);
            this.uiLine1.TabIndex = 30;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSmoothLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(233, 34);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.RectColor = System.Drawing.Color.Teal;
            this.uiSmoothLabel1.Size = new System.Drawing.Size(211, 49);
            this.uiSmoothLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSmoothLabel1.TabIndex = 29;
            this.uiSmoothLabel1.Text = "그래프 정보";
            this.uiSmoothLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // chartTimer
            // 
            this.chartTimer.Enabled = true;
            this.chartTimer.Interval = 2000;
            this.chartTimer.Tick += new System.EventHandler(this.chartTimer_Tick);
            // 
            // AdminUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiSmoothLabel1);
            this.Controls.Add(this.formChart);
            this.Controls.Add(this.uiDouChart);
            this.Controls.Add(this.uiPieChart);
            this.Controls.Add(this.uiBarChart);
            this.Name = "AdminUser";
            this.Size = new System.Drawing.Size(708, 772);
            this.Load += new System.EventHandler(this.AdminUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIBarChart uiBarChart;
        private Sunny.UI.UIPieChart uiPieChart;
        private Sunny.UI.UIDoughnutChart uiDouChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart formChart;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private System.Windows.Forms.Timer chartTimer;
    }
}
