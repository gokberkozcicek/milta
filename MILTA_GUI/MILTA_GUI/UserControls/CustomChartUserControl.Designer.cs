namespace MILTA_GUI
{
    partial class CustomChartUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.resultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).BeginInit();
            this.SuspendLayout();
            // 
            // resultChart
            // 
            chartArea1.Name = "ChartArea1";
            this.resultChart.ChartAreas.Add(chartArea1);
            this.resultChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.resultChart.Legends.Add(legend1);
            this.resultChart.Location = new System.Drawing.Point(0, 0);
            this.resultChart.Name = "resultChart";
            this.resultChart.Size = new System.Drawing.Size(742, 491);
            this.resultChart.TabIndex = 0;
            this.resultChart.Text = "chart1";
            // 
            // CustomChartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultChart);
            this.Name = "CustomChartUserControl";
            this.Size = new System.Drawing.Size(742, 491);
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart resultChart;
    }
}
