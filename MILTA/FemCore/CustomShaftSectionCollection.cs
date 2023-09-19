using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FemCore
{
    public class CustomShaftSectionCollection : List<ShaftSectionData>
    {
        public new void Add(ShaftSectionData shaftSectionData)
        {
            base.Add(shaftSectionData);
        }

         

    }
}
