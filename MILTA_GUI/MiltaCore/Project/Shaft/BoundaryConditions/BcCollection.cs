using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class BcCollection : List<BcData>, IMiltaObject
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "Bc Collection";
        public MiltaObjectTypes MiltaObjectType { get; set; } = MiltaObjectTypes.BCCollection;
        public IMiltaObject ParentObject { get; set; }
        public BcCollection(IMiltaObject parentObject)
        {
            ParentObject = parentObject;
        }
        public new void Add(BcData item)
        {
            item.ParentObject = this;
            base.Add(item);
        }
        public BcData AddDummyBC()
        {
            BcData bc = new BcData();
            bc.ParentObject = this;
            Add(bc);
            return bc;
        }
    }
}
