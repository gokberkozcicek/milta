using MiltaCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MILTA_GUI
{
    public class ForceLoadViewModel:ViewModel
    {
        private MiltaForceLoad ForceLoad { get; set; }


        public override void InitViewModel()
        {
            if (BaseObject == null)
            {
                ForceLoad=BaseObject as MiltaForceLoad;
            }
        }
    }
}
