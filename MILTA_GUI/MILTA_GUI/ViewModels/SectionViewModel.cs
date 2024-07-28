using MiltaCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILTA_GUI
{
    public class SectionViewModel : ViewModel
    {
        private ShaftData shaft;
        private SectionData _section { get; set; }


        public override void InitViewModel()
        {
            if (BaseObject != null)
            {
                _section = BaseObject as SectionData;
                shaft = _section.ParentObject.ParentObject as ShaftData;
                _section.PropertyChanged += Section_PropertyChanged;
                PropertyGrid.SelectedObject = _section;
            }
        }

        private void Section_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var ali = 1;
        }
    }
}
