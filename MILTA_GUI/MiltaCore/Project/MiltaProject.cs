using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class MiltaProject : IMiltaObject
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual string Name { get; set; } = "Milta Project";
        public virtual MiltaObjectTypes MiltaObjectType { get; set; }=MiltaObjectTypes.MiltaProject;
        public ShaftCollection ShaftCollection;
        public MiltaProject() { 
        ShaftCollection = new ShaftCollection();
        }

    }
}
