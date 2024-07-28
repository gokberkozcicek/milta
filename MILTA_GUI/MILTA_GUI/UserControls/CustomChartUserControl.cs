using MiltaCore;
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

namespace MILTA_GUI
{
    public partial class CustomChartUserControl : UserControl
    {
        internal IMiltaObject BaseObject { get; set; }
        public CustomChartUserControl()
        {
            InitializeComponent();
        }
        internal void UpdateChart(IMiltaObject baseObject)
        {
            BaseObject = baseObject;
            switch (BaseObject.MiltaObjectType)
            {
                case MiltaObjectTypes.Force:
                    ForceLoadChart(baseObject);
                    break;

                default:
                    break;
            }
        }
        public void ClearChart()
        {
            BaseObject = null;
            resultChart.ChartAreas.Clear();
        }
        private void ForceLoadChart(IMiltaObject baseObject)
        {
            resultChart.ChartAreas.Clear();
            resultChart.Series.Clear();
            MiltaForceLoad forceObject=baseObject as MiltaForceLoad;

            ChartArea chartArea = new ChartArea("MainArea");
            resultChart.ChartAreas.Add(chartArea);
            chartArea.AxisX.Title = "Step Number";
            chartArea.AxisY.Title = "Force(N)";
            Series fxSeries = new Series("Fx")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.Double,
                YValueType = ChartValueType.Int32,
                BorderWidth = 2
            };
            Series fySeries = new Series("Fy")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.Double,
                YValueType = ChartValueType.Int32,
                BorderWidth = 2
            };
            Series fzSeries = new Series("Fz")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.Double,
                YValueType = ChartValueType.Int32,
                BorderWidth = 2
            };
            foreach (var item in forceObject.Inputs)
            {
                fxSeries.Points.AddXY(item.StepNumber, item.Fx);
                fySeries.Points.AddXY(item.StepNumber, item.Fy);
                fzSeries.Points.AddXY(item.StepNumber, item.Fz);
            }
            resultChart.Series.Add(fxSeries);
            resultChart.Series.Add(fySeries);
            resultChart.Series.Add(fzSeries);
        }
    }
}
