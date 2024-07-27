using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public abstract class SectionData : IMiltaObject
    {
        [Browsable(false)]
        public string Id {get;set;}=Guid.NewGuid().ToString();
        public virtual string Name { get; set; } = "Section";
        [Browsable(false)]
        public virtual MiltaObjectTypes MiltaObjectType { get; set; }
        public double length { get; set; } = 20;
        [Browsable(false)]
        public PointD StartPoint { get; set; }
        [Browsable(false)]
        public virtual SectionTypes SectionType { get; set; }
    }
    public enum SectionTypes
    {
        Outer,
        Inner
    }
}
