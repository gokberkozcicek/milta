using MiltaCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MILTA_GUI
{

    public partial class TabularDisplayUserControl : UserControl
    {
        public ShaftData Shaft { get; set; }
        private IMiltaObject baseObject { get; set; }

        public TabularDisplayUserControl()
        {
            InitializeComponent();
            Shaft = new ShaftData(null);
            SetDataGridSettings();
        }
        public void ClearDisplay()
        {
            resultCustomChartUserControl.ClearChart();
            resultDataGridView.Rows.Clear();
            resultDataGridView.Columns.Clear();
            resultDataGridView.DataSource = null;
        }
        private void SetDataGridSettings()
        {
            resultDataGridView.AllowUserToAddRows = false; 
            resultDataGridView.AllowUserToDeleteRows = false; 
            resultDataGridView.AllowUserToOrderColumns = false; 
            resultDataGridView.AutoGenerateColumns = false;
        }
        internal void UpdateChart(MiltaForceLoad forceLoad)
        {
            resultCustomChartUserControl.UpdateChart(forceLoad);
        }
        public void CreateLoadTable(MiltaForceLoad forceLoad)
        {
            UpdateChart(forceLoad);
            int stepNumber = (Shaft.ParentObject.ParentObject as MiltaProject).AnalysisStepCount;
            baseObject = forceLoad;

            if (forceLoad.Inputs.Count < stepNumber)
            {
                for (int i = forceLoad.Inputs.Count; i < stepNumber; i++)
                {
                    forceLoad.AddDummyForceInput(forceLoad.Inputs.Count + 1);
                }
            }

            resultDataGridView.DataSource = forceLoad.Inputs;

            resultDataGridView.Columns.Clear(); 
            resultDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StepNumber",
                HeaderText = "Step Number",
                ReadOnly = true
            });
            resultDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fx",
                HeaderText = "Fx"
            });
            resultDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fy",
                HeaderText = "Fy"
            });
            resultDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fz",
                HeaderText = "Fz"
            });
            resultDataGridView.ReadOnly = false;
        }

        private void resultDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (baseObject!=null)
            {
                if (baseObject.MiltaObjectType.Equals(MiltaObjectTypes.Force))
                {
                    if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3)
                    {
                        if (!double.TryParse(e.FormattedValue.ToString(), out _))
                        {
                            e.Cancel = true;
                            resultDataGridView.Rows[e.RowIndex].ErrorText = "Please enter a valid double value.";
                        }
                        else
                        {
                            resultDataGridView.Rows[e.RowIndex].ErrorText = string.Empty;
                        }
                    }
                }

            }
        }
    }
}
