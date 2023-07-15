using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometryCore;
using System.Drawing.Drawing2D;

namespace DrawingAreaControlLibrary
{
    public partial class DrawingAreaUserControl: UserControl
    {
        public Geometry Geo = new Geometry();
        public DrawingAreaUserControl()
        {
            InitializeComponent();
        }

        private void DrawingAreaUserControl_Load(object sender, EventArgs e)
        {
            drawingAreaPictureBox.MouseWheel += drawingArea_MouseWheel; //tanımlama
        }
        public void UpdateGeometry()
        {
            Geo.ScreenHeight = drawingAreaPictureBox.Height;
            Geo.ScreenWidth = drawingAreaPictureBox.Width;
            drawingAreaPictureBox.Invalidate();
        }

        private void DrawLine(Graphics g,Line line,Color color,float lineWeight,bool isDashed)
        {
            Pen pen = new Pen(color, lineWeight);
            pen.DashStyle = isDashed ? DashStyle.Dot : DashStyle.Solid;
            g.DrawLine(pen,Geo.ToScreen(line.StartPoint),Geo.ToScreen(line.EndPoint));
        }
        private void drawingAreaPictureBox_Paint(object sender, PaintEventArgs e)
        {
            
            foreach (var item in Geo.Entities)
            {
                DrawLine(e.Graphics, item as Line, Color.Black, 1, true);
            }
        }
        private void Pan(MouseEventArgs e) {
            if (e.Button.Equals(MouseButtons.Middle))
            {
                Geo.OffsetX -= (e.X - Geo.StartPanX) / Geo.ZoomFactor;
                Geo.OffsetY -= (Geo.StartPanY-e.Y) / Geo.ZoomFactor;
                Geo.StartPanX = e.X;
                Geo.StartPanY = e.Y;
                UpdateGeometry();
            }
        }
        
        private void drawingArea_MouseWheel(object sender, MouseEventArgs e)
        {
            Geo.MouseBeforeZoom=Geo.ToWorld(new Point(e.X,e.Y));
            if (e.Delta>0)
            {
                Geo.ZoomFactor *= 1.1F;
            }
            else
            {
                Geo.ZoomFactor *= 0.9F;
            }
            Geo.MouseAfterZoom=Geo.ToWorld(new PointF(e.X,e.Y));
            Geo.OffsetX += (float)(Geo.MouseBeforeZoom.X-Geo.MouseAfterZoom.X);
            Geo.OffsetY += (float)(Geo.MouseBeforeZoom.Y-Geo.MouseAfterZoom.Y);
            UpdateGeometry();
        }
        private void drawingAreaPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Geo.StartPanX = e.X;
            Geo.StartPanY = e.Y;
        }

        private void drawingAreaPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Pan(e);
        }
    }
}
