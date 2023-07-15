using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class TorqueLoad:LoadData
    {
        public override LoadTypesEnum Type { get; set; } = LoadTypesEnum.Torque;
        public override string Name { get; set; } = "Torsion";
        public double Magnitude { get; set; }
        public double Width { get; set; }

    }
}
