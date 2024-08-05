

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
    public class SectionCollectionViewModel : ViewModel
    {
        private ShaftData shaft;
        private SectionCollection _sectionCollection { get; set; }
        private ContextMenuStrip contextMenuStrip;

        public override void InitViewModel()
        {
            if (BaseObject != null)
            {
                _sectionCollection = BaseObject as SectionCollection;
                shaft = _sectionCollection.ParentObject.ParentObject as ShaftData;
                PropertyGrid.SelectedObject = null;

                //context menu
                contextMenuStrip = new ContextMenuStrip();
                ToolStripMenuItem addSectionMenuItem = new ToolStripMenuItem("Add Section");
                contextMenuStrip.Items.Add(addSectionMenuItem);
                addSectionMenuItem.Click += AddSectionMenuItem_Click;
                TreeView.ContextMenuStrip = contextMenuStrip;
            }
        }

        private void AddSectionMenuItem_Click(object sender, EventArgs e)
        {
            SectionData section=_sectionCollection.AddDummyOuterSection();
            UpdateTreeView?.Invoke();

        }

        


    }
}
