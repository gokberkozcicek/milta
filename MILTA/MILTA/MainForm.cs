using DrawingAreaControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiltaCore;
namespace MILTA
{
    public partial class MainForm : Form
    {
        ShaftData shaft;
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateAll()
        {
            shaft.UpdateItems();
            UpdateTreeView();
            drawingAreaUserControl1.UpdateGeometry();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            shaft = new ShaftData();
            nodePropertyGrid.SelectedObject = shaft;
            drawingAreaUserControl1.Shaft=shaft;
            UpdateTreeView();
        }
        #region TreeNode
        private void UpdateTreeView()
        {
            mainTreeView.Nodes.Clear();
            MiltaTreeNode shaftNode = new MiltaTreeNode();
            shaftNode.ImageIndex = 0;
            shaftNode.SelectedImageIndex = 0;
            shaftNode.NodeType = MiltaTreeNodeTypesEnum.Shaft;
            shaftNode.Text = "Shaft";

            //Inner contours
            MiltaTreeNode innerContourNode = new MiltaTreeNode();
            innerContourNode.ImageIndex = 1;
            innerContourNode.SelectedImageIndex = 1;
            innerContourNode.Text = "Inner Contour";
            innerContourNode.NodeType = MiltaTreeNodeTypesEnum.InnerContourHeader;

            foreach (var innerContour in shaft.InnerContours)
            {
                MiltaTreeNode contourNode = new MiltaTreeNode();
                contourNode.ImageIndex = GetImageIndexByContourShape(innerContour.ContourShape);
                contourNode.SelectedImageIndex = GetImageIndexByContourShape(innerContour.ContourShape);
                contourNode.NodeType = MiltaTreeNodeTypesEnum.Contour;
                contourNode.BaseObjectId = innerContour.Id;
                contourNode.Text = innerContour.Name;
                innerContourNode.Nodes.Add(contourNode);
            }

            //outer contours
            MiltaTreeNode outerContourNode = new MiltaTreeNode();
            outerContourNode.ImageIndex = 1;
            outerContourNode.SelectedImageIndex = 1;
            outerContourNode.Text = "Outer Contour";
            outerContourNode.NodeType = MiltaTreeNodeTypesEnum.OuterContourHeader;

            foreach (var outerContour in shaft.OuterContours)
            {
                MiltaTreeNode contourNode = new MiltaTreeNode();
                contourNode.ImageIndex = GetImageIndexByContourShape(outerContour.ContourShape);
                contourNode.SelectedImageIndex = GetImageIndexByContourShape(outerContour.ContourShape);
                contourNode.Text = outerContour.Name;
                contourNode.BaseObjectId = outerContour.Id;
                contourNode.NodeType = MiltaTreeNodeTypesEnum.Contour;
                outerContourNode.Nodes.Add(contourNode);
            }
            shaftNode.Nodes.Add(outerContourNode);
            shaftNode.Nodes.Add(innerContourNode);
            

            mainTreeView.Nodes.Add(shaftNode);
            mainTreeView.ExpandAll();
        }
        private int GetImageIndexByContourShape(ContourShapesEnum shape)
        {
            switch (shape)
            {
                case ContourShapesEnum.None:
                    return 0;
                    break;
                case ContourShapesEnum.Cylinder:
                    return 3;
                    break;
                case ContourShapesEnum.Cone:
                    return 4;
                    break;
                case ContourShapesEnum.Hexagon:
                    return 5;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        #endregion

        #region Contour Toolbar
        private void AddDummyCylinder(ContourTypesEnum type)
        {
            CylinderContour cylinder = new CylinderContour();
            switch (type)
            {
                case ContourTypesEnum.Inner:
                    cylinder.ContourType = ContourTypesEnum.Inner;
                    cylinder.Diameter = 10;
                    cylinder.Length = 10;
                    shaft.InnerContours.Add(cylinder);
                    break;
                case ContourTypesEnum.Outer:
                    cylinder.ContourType = ContourTypesEnum.Outer;
                    shaft.OuterContours.Add(cylinder);
                    break;
                default:
                    break;
            }
           
            UpdateAll();
            drawingAreaUserControl1.ZoomFit();
        }
        private void AddDummyCone(ContourTypesEnum type)
        {
            ConeContour cone = new ConeContour();
            switch (type)
            {
                case ContourTypesEnum.Inner:
                    cone.ContourType = ContourTypesEnum.Inner;
                    cone.D1 = 10;
                    cone.D2 = 15;
                    cone.Length = 10;
                    shaft.InnerContours.Add(cone);
                    break;
                case ContourTypesEnum.Outer:
                    cone.ContourType = ContourTypesEnum.Outer;
                    shaft.OuterContours.Add(cone);
                    break;
                default:
                    break;
            }
            
            UpdateAll();
            drawingAreaUserControl1.ZoomFit();

        }
        private void addOuterCylinderToolStripButton_Click(object sender, EventArgs e)
        {
            AddDummyCylinder(ContourTypesEnum.Outer);
        }

        private void addOuterConeToolStripButton_Click(object sender, EventArgs e)
        {
            AddDummyCone(ContourTypesEnum.Outer);
        }

        private void addInnerCylinderToolStripButton_Click(object sender, EventArgs e)
        {
            AddDummyCylinder(ContourTypesEnum.Inner);
        }

        private void addInnerConeToolStripButton_Click(object sender, EventArgs e)
        {
            AddDummyCone(ContourTypesEnum.Inner);
        }
        #endregion

        private void outerContourToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (mainTreeView.SelectedNode != null)
            {
                MiltaTreeNode selectedNode = mainTreeView.SelectedNode as MiltaTreeNode;
                switch (selectedNode.NodeType)
                {
                    case MiltaTreeNodeTypesEnum.Shaft:
                        nodePropertyGrid.SelectedObject = shaft;
                        break;
                        break;
                    case MiltaTreeNodeTypesEnum.Contour:
                        nodePropertyGrid.SelectedObject=shaft.GetContourById(selectedNode.BaseObjectId);

                        break;
                    default:
                        nodePropertyGrid.SelectedObject = null;
                        break;
                }
            }
        }

        private void nodePropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            UpdateAll();
        }
    }
}
