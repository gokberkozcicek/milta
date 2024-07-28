using MiltaCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MILTA_GUI
{
    public abstract class ViewModel
    {
        public IMiltaObject BaseObject { get; set; }
        public ShaftData ShaftData { get; set; }
        public miltaVTKControl VTK { get; set; }
        public TabularDisplayUserControl TabularDisplay { get; set; }
        public TreeView TreeView { get; set; }
        public PropertyGrid PropertyGrid { get; set; }
        public abstract void InitViewModel();
    }
}
