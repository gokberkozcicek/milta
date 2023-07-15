using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class MomentLoad : LoadData
    {
     
        public override LoadTypesEnum Type { get; set; } = LoadTypesEnum.Moment;
        public override string Name { get; set; } = "Moment";
        public double MagnitudeX { get; set; } = 0;
        public double MagnitudeY { get; set; } = 0;
        public double MagnitudeZ { get; set; } = 0;
    }
}
