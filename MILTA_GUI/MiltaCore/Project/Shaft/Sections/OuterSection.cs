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
        public double OuterDiameter { get; set; }
        public override SectionTypes SectionType { get; set; } = SectionTypes.Outer;
        public OuterSection(double d,double l)
        {
            OuterDiameter = d;
            length= l;
            StartPoint=new PointD(0,0,0);
        }
    }
}
