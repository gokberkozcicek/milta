using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class Material
    {
        string Id {  get; set; }=Guid.NewGuid().ToString();
        public string Name { get; set; } = "MAT";
        public double YoungModulus { get; set; } = 210000;
        public double G { get; set; } = 70000;
        public double PoissonsRatio { get; set; } = 0.3;
        public double YieldStregnth { get; set; } = 300;
        public double UTS { get; set; } = 300;
        public double Density { get; set; } = 7.85;

    }
}
