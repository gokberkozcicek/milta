using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class LoadCollection:List<MiltaLoad>,IMiltaObject
    {
        public string Id {get;set;}=Guid.NewGuid().ToString();
        public string Name { get; set; } = "Load Collection";
        public MiltaObjectTypes MiltaObjectType { get; set; } = MiltaObjectTypes.LoadCollection;
        public new void Add(MiltaLoad item)
        {
            base.Add(item);
        }
        public MiltaForceLoad AddDummyForce()
        {
            MiltaForceLoad miltaForceLoad = new MiltaForceLoad(0, 0, 0, 0);
            Add(miltaForceLoad);
            return miltaForceLoad;
        }
    }
}
