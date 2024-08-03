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
        public IMiltaObject ParentObject { get; set; }
        public LoadCollection(IMiltaObject parentObject)
        {
            ParentObject = parentObject;
        }
        public new void Add(MiltaLoad item)
        {
            item.ParentObject = this;
            base.Add(item);
        }
        public MiltaForceLoad AddDummyForce()
        {
            MiltaForceLoad miltaForceLoad = new MiltaForceLoad(0, 0, 0, 0);
            miltaForceLoad.ParentObject = this;
            Add(miltaForceLoad);
            return miltaForceLoad;
        }
        public void RemoveItem(MiltaLoad item)
        {
            this.RemoveAll(x => x.Id == item.Id);

        }
    }
}
