using GeometryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MILTA
{
    internal class ConeContour:ShaftContourData
    {
        private double _d1 = 30;
        private double _d2 = 40;
        private double _length = 30;
        /// <summary>
        /// constructor
        /// </summary>
        public ConeContour() { }    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d1">Start diameter</param>
        /// <param name="d2">End diameter</param>
        /// <param name="length">contour length</param>
        public ConeContour(double d1, double d2,double length) {
            _d1 = d1;
            _d2 = d2;
            _length = length;
        }
        public double D1 { get { return _d1; } set { _d1 = value; } }
        public double D2 { get { return _d2; } set { _d2 = value; } }
        public override double Length { get { return _length; } set { _length = value; } }
        public override string Name { get; set; } = "Cone";
        public override ContourShapesEnum ContourShape { get; set; } = ContourShapesEnum.Cone;

        public PointD P1, P2, P3, P4;

        public Line L1, L2, L3, L4;
        public override ClosedPath ClosedPath { get { return new ClosedPath(Edges); } }
        public override void SetGeometryEntities()
        {
            P1 = StartPoint.Move(0, D1 / 2);
            P2 = StartPoint.Move(Length, D2 / 2);
            P3 = StartPoint.Move(Length, -D2 / 2);
            P4 = StartPoint.Move(0, -D1 / 2);
            L1 = new Line(P1, P2);
            L2 = new Line(P2, P3);
            L3 = new Line(P3, P4);
            L4 = new Line(P4, P1);
        }
        public override List<PointD> Vertices { get { SetGeometryEntities(); return new List<PointD>() { P1, P2, P3, P4 }; } }
        public override List<EntityData> Edges { get { SetGeometryEntities(); return new List<EntityData>() { L1, L2, L3, L4 }; } }
    }
}
