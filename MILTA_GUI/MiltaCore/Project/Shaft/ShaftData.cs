using MiltaCore.Sections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class ShaftData : IMiltaObject, IMiltaComponent
    {
        [Browsable(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual string Name { get; set; } = "Shaft";
        [Browsable(false)]
        public virtual MiltaObjectTypes MiltaObjectType { get; set; }=MiltaObjectTypes.Shaft;
        [Browsable(false)]
        public MiltaComponentTypes ComponentTypes { get; set; } = MiltaComponentTypes.Shaft;

        [Browsable(false)]  
        public PointD StartPoint { get; set; }
        [Browsable(false)]
        public SectionCollection OuterSections { get; set; }
        [Browsable(false)]
        public SectionCollection InnerSections { get; set; }
      
        public ShaftData() { 
            OuterSections=new SectionCollection();
            InnerSections = new SectionCollection();
            StartPoint=new PointD(0,0,0);
        }
    }
}
