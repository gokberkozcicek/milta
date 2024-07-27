using MiltaCore;
using MiltaCore.Sections;
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
        TabularDisplayUserControl tabularDisplayControl;
        public Main()
        {
            miltaProject= new MiltaProject();
            InitializeComponent();
            InitCustomUserControls();
            mainTreeView.ImageList = mainIımageList;
        }
        private void InitCustomUserControls()
        {
            miltaVTKControl = new miltaVTKControl();
            miltaVTKControl.Dock = DockStyle.Fill;
            tabularDisplayControl=new TabularDisplayUserControl();
            tabularDisplayControl.Dock = DockStyle.Fill;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            drawingAreaSplitContainer.Panel1.Controls.Add(miltaVTKControl);
            drawingAreaSplitContainer.Panel2.Controls.Add(tabularDisplayControl);
            AddDummyProject();

        }
        private void AddDummyProject()
        {
            ShaftData shaft=miltaProject.ShaftCollection.AddDummyShaft();

            shaft.OuterSections.Add(new OuterSection(10,10,30));
            shaft.OuterSections.Add(new OuterSection(10,30,30));
            shaft.OuterSections.Add(new OuterSection(30,30,30));
            shaft.OuterSections.Add(new OuterSection(30,20,30));
            shaft.OuterSections.Add(new OuterSection(20,20,30));
            shaft.Loads.AddDummyForce();

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
                //loads
                CustomTreeNode loadsNode = new CustomTreeNode(shaft.Loads);
                loadsNode.Text = "Loads";
                foreach (var load in shaft.Loads)
                {
                    CustomTreeNode loadNode = new CustomTreeNode(load);
                    loadsNode.Nodes.Add(loadNode);
                }
                shaftNode.Nodes.Add(loadsNode);
            }

            mainTreeView.Nodes.Add(projectNode);
            mainTreeView.ExpandAll();
        }

        private void mainTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            CustomTreeNode selectedNode = e.Node as CustomTreeNode;
            if (selectedNode != null)
            {
                ViewModel viewModel = null ;
                switch (selectedNode.BaseObject.MiltaObjectType)
                {
                    case MiltaObjectTypes.Force:
                        viewModel = new ForceLoadViewModel();
                        break;
                    default:
                        break;
                }
                if (viewModel!=null)
                {
                    viewModel.BaseObject = selectedNode.BaseObject;
                    viewModel.VTK = miltaVTKControl;
                    viewModel.TreeView = mainTreeView;
                    viewModel.PropertyGrid = propertyGrid1;
                    viewModel.InitViewModel();
                }
                
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            miltaVTKControl.Shaft = miltaProject.ShaftCollection.First();
            miltaVTKControl.DrawGeometry();
        }
    }
}
