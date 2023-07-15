using GeometryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILTA
{
    /// <summary>
    /// A class for cylindrical contour definition.
    /// </summary>
    internal class CylinderContour:ShaftContourData
    {
        private double _diameter=20;
        private double _length=40;
        /// <summary>
        /// constructor
        /// </summary>
        public CylinderContour() { 
        
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="diameter">Dimater</param>
        /// <param name="length">Contour length</param>
        public CylinderContour (double diameter, double length)
        {
            _diameter= diameter;
            _length= length; 
        }
        public double Diameter { get { return _diameter; } set { _diameter = value;} }
        public override double Length { get { return _length; } set { _length = value;} }
        public override string Name { get; set; } = "Cylinder";
        public override ContourShapesEnum ContourShape { get; set; }= ContourShapesEnum.Cylinder;
        public PointD P1, P2, P3, P4;

        public Line L1,L2,L3,L4;

        public override void SetGeometryEntities()
        {
            P1 = StartPoint.Move(0, Diameter / 2);
            P2 = StartPoint.Move(Length, Diameter / 2);
            P3 = StartPoint.Move(Length, -Diameter / 2);
            P4 = StartPoint.Move(0, -Diameter / 2);
            L1 = new Line(P1,P2);
            L2 = new Line(P2,P3);
            L3 = new Line(P3,P4);
            L4 = new Line(P4,P1);
        }
        public override List<PointD> Vertices { get { SetGeometryEntities(); return new List<PointD>() { P1,P2,P3,P4}; } }
        public override List<EntityData> Edges { get { SetGeometryEntities(); return new List<EntityData>() { L1,L2,L3,L4}; } }
    }
}
