using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class CustomLoadCollection:List<LoadData>
    {
        public new void Add(LoadData data)
        {
            base.Add(data);

        }
        public LoadData GetLoadById(string Id)
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
        public void UpdateAllLoads()
        {
            this.ForEach(x => x.SetLoads());
        }
    }
}
