using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FemCore
{
    internal class CustomShaftBoundaryCollection : List<ShaftBoundaryConditionData>
    {
        public new void Add(ShaftBoundaryConditionData shaftBoundaryConditionData)
        {
            base.Add(shaftBoundaryConditionData);
        }
    }
}
