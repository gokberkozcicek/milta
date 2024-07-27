using MiltaCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MILTA_GUI
{
    public partial class Main : Form
    {
        miltaVTKControl miltaVTKControl;
        MiltaProject miltaProject;
        public Main()
        {
            miltaProject= new MiltaProject();
            InitializeComponent();
            InitVTKControl();
            mainTreeView.ImageList = mainIımageList;
        }
        private void InitVTKControl()
        {
            miltaVTKControl = new miltaVTKControl();
            miltaVTKControl.Dock = DockStyle.Fill;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            drawingAreaSplitContainer.Panel1.Controls.Add(miltaVTKControl);
            AddDummyProject();

        }
        private void AddDummyProject()
        {
            ShaftData shaft=miltaProject.ShaftCollection.AddDummyShaft();
            shaft.OuterSections.AddDummyOuterSection();
            UpdateTreeView();
        }
        private void UpdateTreeView()
        {
            CustomTreeNode projectNode=new CustomTreeNode(miltaProject);
            foreach (var shaft in miltaProject.ShaftCollection)
            {
                CustomTreeNode shaftNode = new CustomTreeNode(shaft);
                projectNode.Nodes.Add(shaftNode);
                CustomTreeNode outerSectionsNode = new CustomTreeNode(shaft.OuterSections);
                outerSectionsNode.Text = "Outer Sections";
                //outer sections
                foreach (var outerSection in shaft.OuterSections)
                {
                    CustomTreeNode outerSectionNode = new CustomTreeNode(outerSection);
                    outerSectionsNode.Nodes.Add(outerSectionNode);
                }
                shaftNode.Nodes.Add(outerSectionsNode);
            }

            mainTreeView.Nodes.Add(projectNode);
            mainTreeView.ExpandAll();
        }
    }
}
