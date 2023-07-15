using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    public class Circle:EntityData
    {
        public Circle() { }
        public override EntityTypesEnum Type { get; set; }=EntityTypesEnum.Circle;
        public double Radius { get;set; }
        public PointD CenterPoint { get; set; } = new PointD();
        public PointD RectangleStartPoint { get { return CenterPoint.Move(-Radius, Radius); }

            set { }
        } 

        public double Width { get { return Radius * 2; } set { Width = value; } }
        public double Height { get { return Width; } set { Height = value; } }
        public Circle(double radius,PointD centerPoint)
        {
            Radius = radius;
            CenterPoint = centerPoint;
            MakeCircle();
        }
        public override List<PointD> Vertices
        {
            get { return new List<PointD>() { CenterPoint,
                CenterPoint.Move(-Radius,0),
                CenterPoint.Move(+Radius,0),
                CenterPoint.Move(0,+Radius),
                CenterPoint.Move(0,-Radius),
            }; }
        }
        public void MakeCircle()
        {
         
        }
    }
}
