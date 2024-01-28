using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamFEA
{
    public class FeNode
    {
        public FeNode() { }
        public FeNode(int number,double x,double y, double z) {

            Number = number;
            X = x;
            Y = y;
            Z = z;
        }
        public int Number { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}
