using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    internal class CoordinateTransformer
    {
        
        internal CoordinateTransformer() { }

        internal float ZoomFactor { get; set; } = 1F;
        internal float StartPanX { get; set; } = 0F;
        internal float StartPanY { get; set; } = 0F;
        internal float OffsetX { get; set; } = 0F;
        internal float OffsetY { get; set; } = 0F;
        internal int ScreenHeight { get; set; } = 0;
        internal int ScreenWidth { get; set; } = 0;
        internal PointD MouseBeforeZoom { get; set; }=new PointD();
        internal PointD MouseAfterZoom { get; set; }=new PointD();
        internal List<PointD> Vertices { get; set; }

        internal PointF ToScreen(PointD point)
        {
            PointF screenPoint=new PointF();
            screenPoint.X = ((float)point.X - OffsetX) * ZoomFactor;
            screenPoint.Y = (float)(ScreenHeight - ((float)point.Y - OffsetY) * ZoomFactor);
            return screenPoint;
        }
        internal PointD ToWorld(PointF point)
        {
            PointD worldPoint=new PointD();
            worldPoint.X = (double)(point.X / ZoomFactor + OffsetX);
            worldPoint.Y = (double)(-(point.Y-ScreenHeight) / ZoomFactor + OffsetY);
            return worldPoint;
        }
        internal void ZoomFit()
        {
            if (Vertices.Count>0)
            {
                BoundingBox worldBB = new BoundingBox(Vertices);

                double ratio = worldBB.Width / (double)ScreenWidth;
                if (ratio>1)
                {
                    ZoomFactor = (float)(ratio*1.75);
                }
                else
                {
                    ZoomFactor = (float)(1/(ratio*1.75));
                }
                OffsetX = 0;
                OffsetY = 0;
                PointD Wp = ToWorld(new PointF(ScreenWidth / 2, ScreenHeight / 2));
                OffsetX=+(float)(worldBB.CenterPoint.X - Wp.X);
                OffsetY=+(float)(worldBB.CenterPoint.Y - Wp.Y);
               
            
            }
        }
    }
}
