using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamFEA
{
    public  class FeMaterial
    {
        public FeMaterial() { }
        public string Name { get; set; }
        public double E { get; set; }//Young's modulus
        public double G { get; set; }//Shear modulus
        public double A { get; set; }//Cross section area
        public double Iy { get; set; }//Moment of inertia, local y-axis
        public double Iz { get; set; }//Moment of inertia, local z-axis
        public double Ksv { get; set; }//Saint-Venant's torsion constant
    }
}
