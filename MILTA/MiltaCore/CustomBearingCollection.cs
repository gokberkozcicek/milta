using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class CustomBearingCollection:List<BearingData>
    {
        public new void Add(BearingData data)
        {
            base.Add(data);
     
        }
        public BearingData GetBearingById(string Id)
        {
            foreach (var item in this)
            {
                if (item.Id.Equals(Id))
                {
                    return item;
                }
            }
            return null;
        }
        public void UpdateAllBearings()
        {
            this.ForEach(x => x.SetBearing());
        }
    }
}
