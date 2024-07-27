using MiltaCore.Sections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class ShaftData : IMiltaObject
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual string Name { get; set; } = "Shaft";
        public virtual MiltaObjectTypes MiltaObjectType { get; set; }=MiltaObjectTypes.Shaft;
    
        public SectionCollection OuterSections { get; set; }
        public SectionCollection InnerSections { get; set; }
        public ShaftData() { 
            OuterSections=new SectionCollection();
            InnerSections = new SectionCollection();
        }
    }
}
