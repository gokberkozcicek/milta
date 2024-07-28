using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class ShaftCollection : List<ShaftData>, IMiltaObject
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "Shaft Collection";
        public MiltaObjectTypes MiltaObjectType { get; set; } = MiltaObjectTypes.ShaftCollection;
        public IMiltaObject ParentObject { get; set; }
        public ShaftCollection(IMiltaObject parent) {
            ParentObject=parent;    
        }
        public new void Add(ShaftData data)
        {
            data.ParentObject = this;
            base.Add(data);
        }
        public ShaftData AddDummyShaft()
        {
            ShaftData shaft=new ShaftData(this);
            Add(shaft);
            return shaft;
        }
    }
}
