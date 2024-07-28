using MiltaCore.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore.Sections
{
    public class OuterSection:SectionData
    {
        public override string Name { get; set; } = "Outer Section";
        public override MiltaObjectTypes MiltaObjectType { get; set; } = MiltaObjectTypes.Section;

        private double _d1= 30;
        public double D1
        {
            get { return _d1; }
            set
            {
                var oldValue = _d1;
                _d1 = value;
                Notify("D1", oldValue, _d1, Id);
            }
        }
        private double _d2 = 30;
        public double D2
        {
            get { return _d2; }
            set
            {
                var oldValue = _d2;
                _d2 = value;
                Notify("D2", oldValue, _d2, Id);
            }
        }
        public override SectionTypes SectionType { get; set; } = SectionTypes.Outer;
        public OuterSection(double d1, double d2, double l)
        {
            D1 = d1;
            D2 = d2;
            Length= l;
            StartPoint=new PointD(0,0,0);
            ParentObject = null;
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
            p2.AppendMove(Length, h2, 0);
            p3.AppendMove(Length, -h2, 0);
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
