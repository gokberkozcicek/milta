using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kitware.VTK;
namespace MILTA_GUI
{
    public partial class miltaVTKControl : UserControl
    {
        RenderWindowControl renderWindowControl;
        public miltaVTKControl()
        {
            InitializeComponent();
            renderWindowControl= new RenderWindowControl();
            renderWindowControl.Dock = DockStyle.Fill;
            renderWindowControl.Load += RenderWindowControl_Load;
        }

        private void RenderWindowControl_Load(object sender, EventArgs e)
        {
            Cylinder(); ;
        }
        private void Cylinder()
        {
            // Create a cylinder.  
            vtkCylinderSource cylinderSource = vtkCylinderSource.New();
            cylinderSource.SetCenter(0.0, 0.0, 0.0);
            cylinderSource.SetRadius(5.0);
            cylinderSource.SetHeight(7.0);
            cylinderSource.SetResolution(36);
            // Visualize
            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(cylinderSource.GetOutputPort());
            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            vtkRenderWindow renderWindow = renderWindowControl.RenderWindow;
            vtkRenderer renderer = renderWindow.GetRenderers().GetFirstRenderer();
            renderer.SetBackground(0.1, 0.3, 0.2);
            renderer.AddActor(actor);
            renderer.ResetCamera();
        }
        private void miltaVTKControl_Load(object sender, EventArgs e)
        {
            vtkToolStripContainer.ContentPanel.Controls.Add(renderWindowControl);
        }
    }
}
