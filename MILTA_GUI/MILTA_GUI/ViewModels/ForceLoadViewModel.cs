using MiltaCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;
namespace MILTA_GUI
{
    public class ForceLoadViewModel:ViewModel
    {
        private ShaftData shaft;
        private MiltaForceLoad ForceLoad { get; set; }


        public override void InitViewModel()
        {
            if (BaseObject != null)
            {
                ForceLoad=BaseObject as MiltaForceLoad;
                shaft=ForceLoad.ParentObject.ParentObject as ShaftData;
                ForceLoad.PropertyChanged += ForceLoad_PropertyChanged;
                CreateDataTable();
            }
        }
        private void CreateDataTable()
        {
            TabularDisplay.Shaft = shaft;
            TabularDisplay.CreateLoadTable(ForceLoad);
            PropertyGrid.SelectedObject = ForceLoad;
        }

        private void ForceLoad_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            TabularDisplay.UpdateChart(ForceLoad);
        }
    }
}
