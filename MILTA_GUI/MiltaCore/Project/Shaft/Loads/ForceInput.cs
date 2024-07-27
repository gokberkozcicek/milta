using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class ForceInput
    {
        public int StepNumber { get; set; } = 0;
        public double Fx { get; set; } = 0;
        public double Fy { get; set; } = 0;
        public double Fz { get; set; } = 0;
        public ForceInput(int stepNumber, double fx, double fy, double fz)
        {
            StepNumber = stepNumber;
            Fx = fx;
            Fy = fy;
            Fz = fz;
        }
    }
}
