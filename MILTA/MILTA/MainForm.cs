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

        private void MainForm_Load(object sender, EventArgs e)
        {
            shaft = new ShaftData();
            shaft.InnerContours.Add(new CylinderContour());
            shaft.InnerContours.Add(new ConeContour());
            shaft.InnerContours.Add(new CylinderContour());
            shaft.OuterContours.Add(new CylinderContour());
            shaft.OuterContours.Add(new ConeContour());
            shaft.OuterContours.Add(new CylinderContour());
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

            shaftNode.Nodes.Add(innerContourNode);
            shaftNode.Nodes.Add(outerContourNode);

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

    }
}
