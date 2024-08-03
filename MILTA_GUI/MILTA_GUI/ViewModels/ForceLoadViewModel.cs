using MiltaCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;
using MiltaCore.Sections;
using static System.Collections.Specialized.BitVector32;
namespace MILTA_GUI
{
    public class ForceLoadViewModel:ViewModel
    {
        private ShaftData shaft;
        private MiltaForceLoad _forceLoad { get; set; }
        private ContextMenuStrip contextMenuStrip;

        public override void InitViewModel()
        {
            if (BaseObject != null)
            {
                _forceLoad=BaseObject as MiltaForceLoad;
                shaft=_forceLoad.ParentObject.ParentObject as ShaftData;
                _forceLoad.PropertyChanged += ForceLoad_PropertyChanged;
                PropertyGrid.SelectedObject = _forceLoad;
                CreateDataTable();
                //context menu
                contextMenuStrip = new ContextMenuStrip();
                ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
                contextMenuStrip.Items.Add(deleteMenuItem);
                deleteMenuItem.Click += DeleteMenuItem_Click;
                TreeView.ContextMenuStrip = contextMenuStrip;
            }
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            (_forceLoad.ParentObject as LoadCollection).RemoveItem(_forceLoad);
            TreeView.Nodes.Remove(TreeView.SelectedNode);
            //update vtk
        }
  
        private void CreateDataTable()
        {
            TabularDisplay.Shaft = shaft;
            TabularDisplay.CreateLoadTable(_forceLoad);
            
        }

        private void ForceLoad_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            TabularDisplay.UpdateChart(_forceLoad);
        }
    }
}
