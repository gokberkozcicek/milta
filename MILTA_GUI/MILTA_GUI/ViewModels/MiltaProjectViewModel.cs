using MiltaCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILTA_GUI
{
    public class MiltaProjectViewModel : ViewModel
    {
        private ShaftData shaft;


        public override void InitViewModel()
        {
            if (BaseObject != null)
            {
                shaft = null;
                MiltaProject project= BaseObject as MiltaProject;
                PropertyGrid.SelectedObject = project;
                project.PropertyChanged += Project_PropertyChanged;
            }
        }

        private void Project_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
