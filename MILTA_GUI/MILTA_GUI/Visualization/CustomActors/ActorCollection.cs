using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILTA_GUI
{
    public class ActorCollection:List<CustomActor>
    {
        public new void Add(CustomActor item)
        {
            base.Add(item);
        }
    }
}
