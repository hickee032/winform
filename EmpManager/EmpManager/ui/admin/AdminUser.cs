using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace winform1219.ui.admin
{
    public partial class AdminUser : UserControl
    {
        Random ra = new Random(DateTime.Now.Millisecond);
        int[] sal = { 100000, 200000, 500000, 300000, 400000 };
        string[] name = { "홍사원", "김주임", "박대리", "이과장", "최부장" };
        public AdminUser()
        {
            InitializeComponent();
            formChart.Titles.Add("생산부 급여/상여금");
        }

        void initBarChart()
        {
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "개발부";
            //option.Title.SubText = "<개발부>";

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            option.Legend.AddData("급여");
            option.Legend.AddData("상여금");

            var series = new UIBarSeries();
            series.Name = "개발부급여";
            series.AddData(10);
            series.AddData(20);
            series.AddData(30);
            series.AddData(40);
            series.AddData(50);
            option.Series.Add(series);

            series = new UIBarSeries();
            series.Name = "개발부상여금";
            series.AddData(1);
            series.AddData(2);
            series.AddData(3);
            series.AddData(4);
            series.AddData(5);
            option.Series.Add(series);

            option.XAxis.Data.Add("홍사원");
            option.XAxis.Data.Add("김주임");
            option.XAxis.Data.Add("박대리");
            option.XAxis.Data.Add("이과장");
            option.XAxis.Data.Add("최차장");

            option.ToolTip.Visible = true;
            option.YAxis.Scale = true;

            //option.XAxis.Name = "이름";
            //option.YAxis.Name = "급여";
            option.ToolTip.AxisPointer.Type = 
                UIAxisPointerType.Shadow;
            uiBarChart.SetOption(option);
        }

        private void initPieChart()
        {
            var option = new UIPieOption();
            option.Title = new UITitle();
            option.Title.Text = "관리부 급여";
            //option.Title.SubText = "<관리부>";
            option.Title.Left = UILeftAlignment.Center;
            option.ToolTip.Visible = true;

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

            option.Legend.AddData("평균 급여");
            option.Legend.AddData("평균 상여금");

            var series = new UIPieSeries();
            series.Name = "관리부급여";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;

            series.AddData("급여", 90);
            series.AddData("상여금", 10);

            option.Series.Clear();
            option.Series.Add(series);
            uiPieChart.SetOption(option);
        }

        private void initDouChart()
        {
            var option = new UIDoughnutOption();
            option.Title = new UITitle();
            option.Title.Text = "영업부 매출";
            //option.Title.SubText = "년도별 매출";
            option.Title.Left = UILeftAlignment.Center;
            option.ToolTip.Visible = true;

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

            option.Legend.AddData("2020년");
            option.Legend.AddData("2021년");
            option.Legend.AddData("2022년");

            var series = new UIDoughnutSeries();
            series.Name = "영업부매출";
            series.Center = new UICenter(50, 55);
            series.Radius.Inner = 40;
            series.Radius.Outer = 70;
            series.Label.Show = true;
            series.Label.Show = true;
            series.Label.Position = UIPieSeriesLabelPosition.Center;

            series.AddData("2020년", 500000000);
            series.AddData("2021년", 200000000);
            series.AddData("2022년", 300000000);

            option.Series.Clear();
            option.Series.Add(series);
            uiDouChart.SetOption(option);
        }

        private void initFormChart()
        {
            formChart.Series.Clear();
            formChart.Series.Add("급여");
            formChart.Series.Add("상여금");
            formChart.ChartAreas[0].AxisX.Title = "생산부직원";
            formChart.Series["급여"].LegendText = "급여";
            for (int i = 0; i < sal.Length; i++)
            {
                formChart.Series["급여"].Points.AddXY(name[i], 
                    sal[ra.Next(5)]);
            }

            formChart.Series["상여금"].LegendText = "상여금";
            for (int i = 0; i < sal.Length; i++)
            {
                formChart.Series["상여금"].Points.AddXY(name[i], 
                    sal[ra.Next(5)]);
            }
        }

        private void AdminUser_Load(object sender, EventArgs e)
        {
            initBarChart();
            initPieChart();
            initDouChart();
            initFormChart();
        }

        private void chartTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                uiBarChart.Update("개발부급여", i, ra.Next(100, 1000));
                uiBarChart.Update("개발부상여금", i, ra.Next(100, 1000));
            }
            uiBarChart.Refresh();

            uiDouChart.Update("영업부매출", "2020년", ra.Next(100, 1000));
            uiDouChart.Update("영업부매출", "2021년", ra.Next(100, 1000));
            uiDouChart.Update("영업부매출", "2022년", ra.Next(100, 1000));
            uiDouChart.Refresh();

            uiPieChart.Update("관리부급여", "급여", ra.Next(100, 1000));
            uiPieChart.Update("관리부급여", "상여금", ra.Next(100, 1000));
            uiPieChart.Refresh();

            initFormChart();
        }
    }
}
