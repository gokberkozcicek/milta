using MiltaCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILTA_GUI.ViewModels
{
    public class ShaftViewModel : ViewModel
    {
        private ShaftData shaft;


        public override void InitViewModel()
        {
            if (BaseObject != null)
            {
                shaft = BaseObject as ShaftData;
                PropertyGrid.SelectedObject = shaft;
            }
        }

        private void Section_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
        }
    }
}
