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
using MiltaCore;
namespace MILTA_GUI
{
    public partial class miltaVTKControl : UserControl
    {
        public ShaftData Shaft { get; set; }
        RenderWindowControl renderWindowControl;
        vtkRenderer baseRenderer;
        public miltaVTKControl()
        {
            InitializeComponent();
            renderWindowControl= new RenderWindowControl();
            renderWindowControl.Dock = DockStyle.Fill;
            renderWindowControl.Load += RenderWindowControl_Load;
            baseRenderer = vtkRenderer.New();
        }

        private void RenderWindowControl_Load(object sender, EventArgs e)
        {
            
        }
        
        public void DrawGeometry()
        {
            RemoveAllViewProps();
            

            renderWindowControl.RenderWindow.AddRenderer(baseRenderer);
            OuterContourActor contourActor = new OuterContourActor();
            contourActor.ContourCells = Shaft.OuterSections.GetCells();

            baseRenderer.AddActor(contourActor.GetActor());
            baseRenderer.SetBackground(0.1, 0.2, 0.4);  
            baseRenderer.Render();
            
        }
        private void RemoveAllViewProps()
        {
            baseRenderer.RemoveAllViewProps();
        }
        private void miltaVTKControl_Load(object sender, EventArgs e)
        {
            vtkToolStripContainer.ContentPanel.Controls.Add(renderWindowControl);
        }
    }
}
