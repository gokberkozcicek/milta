using MiltaCore;
using MiltaCore.Sections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MILTA_GUI
{
    public class SectionViewModel : ViewModel
    {
        private ShaftData shaft;
        private SectionData _section { get; set; }
        private ContextMenuStrip contextMenuStrip;

        public override void InitViewModel()
        {
            if (BaseObject != null)
            {
                _section = BaseObject as SectionData;
                shaft = _section.ParentObject.ParentObject as ShaftData;
                _section.PropertyChanged += Section_PropertyChanged;
                PropertyGrid.SelectedObject = _section;

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
            (_section.ParentObject as SectionCollection).RemoveItem(_section);
            TreeView.Nodes.Remove(TreeView.SelectedNode);
            shaft.SetPoints();
            UpdateGeometry?.Invoke();
            //update vtk
        }

        private void Section_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
        }

     
    }
}
