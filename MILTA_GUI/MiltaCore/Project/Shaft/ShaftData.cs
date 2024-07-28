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
        [Browsable(false)]
        public BcCollection Bcs { get; set; }
        [Browsable(false)]
        public LoadCollection Loads { get; set; }

        public IMiltaObject ParentObject { get; set; }

        public ShaftData(IMiltaObject parent) { 
            OuterSections=new SectionCollection(this);
            InnerSections = new SectionCollection(this);
            Bcs = new BcCollection(this);
            Loads=new LoadCollection(this);
            StartPoint=new PointD(0,0,0);
            ParentObject = parent;
        }
    }
}
