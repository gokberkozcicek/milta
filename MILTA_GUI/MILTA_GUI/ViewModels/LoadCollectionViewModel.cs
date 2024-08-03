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
    public class LoadCollectionViewModel : ViewModel
    {
        private ShaftData shaft;
        private LoadCollection _loadCollection { get; set; }
        private ContextMenuStrip contextMenuStrip;
        public delegate void UpdateTreeViewDelegate();
        public UpdateTreeViewDelegate UpdateTreeView;

        public override void InitViewModel()
        {
            if (BaseObject != null)
            {
                _loadCollection = BaseObject as LoadCollection;
                shaft = _loadCollection.ParentObject.ParentObject as ShaftData;
                PropertyGrid.SelectedObject = null;

                //context menu
                contextMenuStrip = new ContextMenuStrip();
                ToolStripMenuItem addForceMenuItem = new ToolStripMenuItem("Add Force");
                contextMenuStrip.Items.Add(addForceMenuItem);
                addForceMenuItem.Click += AddForceMenuItem_Click;
                TreeView.ContextMenuStrip = contextMenuStrip;
            }
        }

        private void AddForceMenuItem_Click(object sender, EventArgs e)
        {
            MiltaForceLoad section = _loadCollection.AddDummyForce();
            UpdateTreeView?.Invoke();
        }

    }
}
