using MiltaCore.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore.Sections
{
    public class OuterSection:SectionData
    {
        public override string Name { get; set; } = "Outer Section";
        public override MiltaObjectTypes MiltaObjectType { get; set; } = MiltaObjectTypes.Section;
        public double D1 { get; set; }
        public double D2 { get; set; }
        public override SectionTypes SectionType { get; set; } = SectionTypes.Outer;
        public OuterSection(double d1, double d2, double l)
        {
            D1 = d1;
            D2 = d2;
            length= l;
            StartPoint=new PointD(0,0,0);
        }
        public override List<MiltaCell> GetCells()
        {
            PointDCollection points = new PointDCollection();
            double h1 = D1 / 2;
            double h2 = D2 / 2;
            PointD p1 = StartPoint.DeepCopy();
            PointD p2 = StartPoint.DeepCopy();
            PointD p3 = StartPoint.DeepCopy();
            PointD p4 = StartPoint.DeepCopy();
            p1.AppendMove(0, h1, 0);
            p2.AppendMove(length, h2, 0);
            p3.AppendMove(length, -h2, 0);
            p4.AppendMove(0, -h1, 0);
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);
            return new List<MiltaCell> { 
                new MiltaCell() { 
                Points=points,
                Id=this.Id
                } 
            };

        }
    }
}
