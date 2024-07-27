using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class MiltaProject : IMiltaObject
    {
        [Browsable(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [ReadOnly(true)]
        public virtual string Name { get; set; } = "Milta Project";
        [Browsable(false)]
        public virtual MiltaObjectTypes MiltaObjectType { get; set; }=MiltaObjectTypes.MiltaProject;
        [Browsable(false)]
        public ShaftCollection ShaftCollection;
        public MiltaProject() { 
        ShaftCollection = new ShaftCollection();
        }
       
    }
}
