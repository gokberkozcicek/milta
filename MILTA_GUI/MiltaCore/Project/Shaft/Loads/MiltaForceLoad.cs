using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class MiltaForceLoad:MiltaLoad
    {
        public override string Name { get; set; } = "Force";
        public override MiltaObjectTypes MiltaObjectType { get; set; } = MiltaObjectTypes.Force;
        [Browsable(false)]
        public Dictionary<int,ForceInput> Inputs { get; set; }

        public MiltaForceLoad() { }
        public MiltaForceLoad(double location,double fx, double fy, double fz)
        {
            Location = location;
            Inputs = new Dictionary<int, ForceInput>();
        }
    }
}
