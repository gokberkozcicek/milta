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

namespace MILTA
{
    public partial class MainForm : Form
    {
        ShaftData shaft;
        public MainForm()
        {
            InitializeComponent();
        }
        private void UpdateGeometry()
        {
            drawingAreaUserControl1.ClearGeometry();
            shaft.OuterContours.ForEach(x => drawingAreaUserControl1.Geo.AddEntity(x.ClosedPath));
            drawingAreaUserControl1.UpdateGeometry();
        }
        private void UpdateAll()
        {
            UpdateTreeView();
            UpdateGeometry();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            shaft = new ShaftData();
            nodePropertyGrid.SelectedObject = shaft;
            UpdateTreeView();
        }
        #region TreeNode
        private void UpdateTreeView()
        {
            mainTreeView.Nodes.Clear();
            MiltaTreeNode shaftNode = new MiltaTreeNode();
            shaftNode.ImageIndex = 0;
            shaftNode.SelectedImageIndex = 0;
            shaftNode.Text = "Shaft";

            //Inner contours
            MiltaTreeNode innerContourNode = new MiltaTreeNode();
            innerContourNode.ImageIndex = 1;
            innerContourNode.SelectedImageIndex = 1;
            innerContourNode.Text = "Inner Contour";

            foreach (var innerContour in shaft.InnerContours)
            {
                MiltaTreeNode contourNode = new MiltaTreeNode();
                contourNode.ImageIndex = GetImageIndexByContourShape(innerContour.ContourShape);
                contourNode.SelectedImageIndex = GetImageIndexByContourShape(innerContour.ContourShape);
                contourNode.Text = innerContour.Name;
                innerContourNode.Nodes.Add(contourNode);
            }

            //outer contours
            MiltaTreeNode outerContourNode = new MiltaTreeNode();
            outerContourNode.ImageIndex = 1;
            outerContourNode.SelectedImageIndex = 1;
            outerContourNode.Text = "Outer Contour";

            foreach (var outerContour in shaft.OuterContours)
            {
                MiltaTreeNode contourNode = new MiltaTreeNode();
                contourNode.ImageIndex = GetImageIndexByContourShape(outerContour.ContourShape);
                contourNode.SelectedImageIndex = GetImageIndexByContourShape(outerContour.ContourShape);
                contourNode.Text = outerContour.Name;
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
    }
}
