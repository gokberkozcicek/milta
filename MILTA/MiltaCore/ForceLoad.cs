using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class ForceLoad:LoadData
    {
        public override LoadTypesEnum Type { get; set; } = LoadTypesEnum.Force;
        public override string Name { get; set; } = "Force";
        public double MagnitudeX { get; set; } = 0;
        public double MagnitudeY{ get; set; } = 0;
        public double MagnitudeZ { get; set; } = 0;
    }
}
