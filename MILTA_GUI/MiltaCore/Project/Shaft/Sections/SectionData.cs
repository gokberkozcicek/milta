using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public abstract class SectionData : IMiltaObject
    {
        public string Id {get;set;}=Guid.NewGuid().ToString();
        public virtual string Name { get; set; } = "Section";
        public virtual MiltaObjectTypes MiltaObjectType { get; set; }
        public double length { get; set; } = 20;
        public PointD StartPoint { get; set; }
        public virtual SectionTypes SectionType { get; set; }
    }
    public enum SectionTypes
    {
        Outer,
        Inner
    }
}
