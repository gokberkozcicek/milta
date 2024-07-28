using MiltaCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILTA_GUI.ViewModels
{

    public class BcViewModel : ViewModel
    {
        private ShaftData shaft;
        private BcData Bc { get; set; }


        public override void InitViewModel()
        {
            if (BaseObject != null)
            {
                Bc = BaseObject as BcData;
                shaft = Bc.ParentObject.ParentObject as ShaftData;
                Bc.PropertyChanged += ForceLoad_PropertyChanged;
                PropertyGrid.SelectedObject = Bc;
            }
        }
        private void ForceLoad_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
        }
    }
}
