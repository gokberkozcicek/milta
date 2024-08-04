using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private vtkRenderer _baseRenderer;
        private vtkRenderer _selectionRenderer;
        private vtkRenderer _overlayRenderer;
        private vtkRenderWindow _renderWindow;
        private vtkRenderWindowInteractor _renderWindowInteractor;
        private vtkInteractorStyleControl _style;

        ActorCollection Actors;
        public miltaVTKControl()
        {
            InitializeComponent();
            renderWindowControl= new RenderWindowControl();
            renderWindowControl.Dock = DockStyle.Fill;
            renderWindowControl.Load += RenderWindowControl_Load;
            Actors = new ActorCollection();

            _baseRenderer = vtkRenderer.New();
            _selectionRenderer = vtkRenderer.New();
            _overlayRenderer = vtkRenderer.New();


            _renderWindow = vtkRenderWindow.New();
            _renderWindow.SetParentId(this.Handle);
            _renderWindow.SetNumberOfLayers(3);

            _renderWindow.AddRenderer(_baseRenderer);
            _renderWindow.AddRenderer(_overlayRenderer);
            _renderWindow.AddRenderer(_selectionRenderer);


            _renderWindowInteractor = vtkRenderWindowInteractor.New();
            _renderWindowInteractor.SetInteractorStyle(_style);

            _renderWindow.SetInteractor(_renderWindowInteractor);
        }

        private void RenderWindowControl_Load(object sender, EventArgs e)
        {
            
        }
        
        public void DrawGeometry()
        {
            RemoveAllViewProps();
            renderWindowControl.RenderWindow.AddRenderer(_baseRenderer);
            OuterContourActor contourActor = new OuterContourActor();
            contourActor.ContourCells = Shaft.OuterSections.GetCells();
            Actors.Add(contourActor);

            _baseRenderer.AddActor(contourActor.GetActor());
            _baseRenderer.SetBackground(0.1, 0.2, 0.4);  
            _baseRenderer.Render();
            
        }
        private void RemoveAllViewProps()
        {
            _baseRenderer.RemoveAllViewProps();
        }
        private void miltaVTKControl_Load(object sender, EventArgs e)
        {
            vtkToolStripContainer.ContentPanel.Controls.Add(renderWindowControl);
        }
    }
}
