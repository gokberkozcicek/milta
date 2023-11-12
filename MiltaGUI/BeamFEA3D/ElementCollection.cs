using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamFEA3D
{
    public class ElementCollection:List<ElementData>
    {
        public new void Add(ElementData element)
        {
            base.Add(element);
        }
    }
}
