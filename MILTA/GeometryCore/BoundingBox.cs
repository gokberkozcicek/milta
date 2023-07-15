using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    public class BoundingBox
    {
        private List<PointD> _points;
        public PointD P1 { get; set; }=new PointD();
        public PointD P2 { get; set; }=new PointD();
        public PointD P3 { get; set; }=new PointD();
        public PointD P4 { get; set; }=new PointD();
        public PointD CenterPoint { get; set; } =new PointD();
        public double Width { get; set; } = 0;
        public double Height { get; set; } = 0;
        public BoundingBox() { }
        public BoundingBox(List<PointD> points) {

            _points = points;
            SetBoundingBox();
        }
        public void SetBoundingBox()
        {
            var x_query=from PointD point in _points select point.X;
            var y_query=from PointD point in _points select point.Y;

            P1=new PointD(x_query.Min(),y_query.Max());
            P2=new PointD(x_query.Max(),y_query.Max());
            P3=new PointD(x_query.Max(),y_query.Min());
            P4=new PointD(x_query.Min(),y_query.Min());

            Width=P1.DistanceToPoint(P2);
            Height=P1.DistanceToPoint(P4);

            CenterPoint = AnalyticalCalculations.GetCenterPointsOfPointList(new List<PointD>() { P1,P2,P3,P4});
        }
    }
}
