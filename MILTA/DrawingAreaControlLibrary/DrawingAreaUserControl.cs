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
using MiltaCore;
using System.Drawing.Text;

namespace DrawingAreaControlLibrary
{
    public partial class DrawingAreaUserControl: UserControl
    {
        public Geometry Geo = new Geometry();
        public ShaftData Shaft=new ShaftData();
        public DrawingAreaUserControl()
        {
            InitializeComponent();
        }

        private void DrawingAreaUserControl_Load(object sender, EventArgs e)
        {
            drawingAreaPictureBox.MouseWheel += drawingArea_MouseWheel;
            ZoomFit();
        }
        public void UpdateGeometry()
        {
            Geo.ScreenHeight = drawingAreaPictureBox.Height;
            Geo.ScreenWidth = drawingAreaPictureBox.Width;

            drawingAreaPictureBox.Invalidate();
        }
        public void ZoomFit()
        {
            Geo.ZoomPoints = Shaft.Vertices;
            Geo.ZoomFit();
        }
        private void DrawLine(Graphics g,Line line,Color color,float lineWeight,bool isDashed,bool isHighlighted=false)
        {
            Color penColor=isDashed ? Color.Blue : Color.Black;
            Pen pen = new Pen(penColor, lineWeight);
            pen.DashStyle = isDashed ? DashStyle.Dash : DashStyle.Solid;
            g.DrawLine(pen,Geo.ToScreen(line.StartPoint),Geo.ToScreen(line.EndPoint));
        }
        private void DrawClosedPath(Graphics g,ClosedPath closedPath, bool isHighlighted = false) {
            
            GraphicsPath path = new GraphicsPath();
           foreach (var item in closedPath.Edges) {
                if (item.Type.Equals(EntityTypesEnum.Line))
                {
                    path.AddLine(Geo.ToScreen((item as Line).StartPoint), Geo.ToScreen((item as Line).StartPoint));
                }
               
            }
           
            path.CloseFigure();

            Color centerColor = Color.FromArgb(255, 240, 240, 240);
            Color edgeColor = Color.FromArgb(195,195,195);
            LinearGradientBrush brush = new LinearGradientBrush(Geo.ToScreen(closedPath.BoundingBox.P1), Geo.ToScreen(closedPath.BoundingBox.P4), edgeColor, edgeColor);
            ColorBlend color_blend = new ColorBlend();

            color_blend.Colors = new Color[] { edgeColor,centerColor,edgeColor };
            color_blend.Positions = new float[] { 0f, 0.5f, 1f };
            brush.InterpolationColors = color_blend;
       
            g.FillPath(brush, path);
            Color penColor = isHighlighted ? Color.Blue : Color.Black;
            float weight=isHighlighted ? 2f : 1f;
            g.DrawPath(new Pen(penColor, weight), path);
        }
        public void ClearGeometry()
        {
            Geo.Entities.Clear();
        }
        private void drawingAreaPictureBox_Paint(object sender, PaintEventArgs e)
        {

            foreach (ShaftContourData outerContour in Shaft.OuterContours)
            {
                DrawClosedPath(e.Graphics, outerContour.ClosedPath,outerContour.IsHighlighted);
            }
            foreach (ShaftContourData innerContour in Shaft.InnerContours)
            {
                foreach (var edge in innerContour.Edges)
                {
                    DrawLine(e.Graphics, edge as Line, Color.Black, 1, true,innerContour.IsHighlighted);
                }
            }
            foreach (var bearing in Shaft.Bearings)
            {
                DrawBearings(e.Graphics,bearing);
            }
            DrawAxis(e.Graphics);
        }
        private void DrawText(Graphics g, PointF point, string text, float size = 12F)
        {
            var fontFamily = new FontFamily("Consolas");
            var font = new Font(fontFamily, size, FontStyle.Regular, GraphicsUnit.Pixel);
            var solidBrush = new SolidBrush(Color.Green);
            

            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            
            g.DrawString(text, font, solidBrush, point);
        }
        private void DrawAxis(Graphics g) { 
            PointF centerPoint=Geo.ToScreen(new PointD(0,0));

            PointF yPoint = new PointF();
             yPoint.X = centerPoint.X;
            yPoint.Y = centerPoint.Y - 50 ;

            PointF xpoint= new PointF();
            xpoint.X = centerPoint.X+50;
            xpoint.Y = centerPoint.Y;
            Color penColor = Color.Green;
            Pen pen = new Pen(penColor, 5);
            pen.EndCap = LineCap.ArrowAnchor;
            pen.StartCap = LineCap.Round;
            pen.DashStyle = DashStyle.Solid;
            
            g.DrawLine(pen,centerPoint,xpoint);
            g.DrawLine(pen,centerPoint,yPoint);

            yPoint.Y -= 12F;
            yPoint.X -= 6F;
            xpoint.Y -= 6F;
            DrawText(g, yPoint, "Y");
            DrawText(g, xpoint, "X");

          
        }
        private void DrawBearings(Graphics g,BearingData bearing)
        {
            foreach (var closedPath in bearing.ClosedPaths)
            {
                GraphicsPath path = new GraphicsPath();
                foreach (var item in closedPath.Edges)
                {
                    if (item.Type.Equals(EntityTypesEnum.Line))
                    {
                        path.AddLine(Geo.ToScreen((item as Line).StartPoint), Geo.ToScreen((item as Line).StartPoint));
                    }
                    if (item.Type.Equals(EntityTypesEnum.Circle))
                    {
                   
                        Circle c1 = item as Circle;
                        RectangleF rectangleF = new RectangleF();
                        rectangleF.X = Geo.ToScreen(c1.RectangleStartPoint).X;
                        rectangleF.Y = Geo.ToScreen(c1.RectangleStartPoint).Y;
                        rectangleF.Width = (float)c1.Width * Geo.ZoomFactor;
                        rectangleF.Height = (float)c1.Height * Geo.ZoomFactor;
                        path.AddEllipse(rectangleF);
                    }

                }

                path.CloseFigure();

                Color centerColor = Color.FromArgb(255, 240, 240, 240);
                Color edgeColor = Color.FromArgb(236, 190, 60);
                LinearGradientBrush brush = new LinearGradientBrush(Geo.ToScreen(closedPath.BoundingBox.P1), Geo.ToScreen(closedPath.BoundingBox.P4), edgeColor, edgeColor);
                ColorBlend color_blend = new ColorBlend();

                color_blend.Colors = new Color[] { edgeColor, centerColor, edgeColor };
                color_blend.Positions = new float[] { 0f, 0.5f, 1f };
                brush.InterpolationColors = color_blend;

                g.FillPath(brush, path);
                g.DrawPath(Pens.Black, path);
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

        private void drawingAreaPictureBox_ClientSizeChanged(object sender, EventArgs e)
        {
            ZoomFit();
            UpdateGeometry();
        }

        private void drawingAreaPictureBox_SizeChanged(object sender, EventArgs e)
        {
            ZoomFit();
            UpdateGeometry();
        }
    }
}
