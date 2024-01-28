using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamFEA
{
    public class FeElement
    {
        /// <summary>
        /// 3D elastic bernoulli beam element
        /// </summary>
        public int Number {  get; set; }
        public int[] NodeNumbers { get; set; }
        public FeElement() { }
        public FeElement(int number, int[] nodeNumbers)
        {
            Number = number;
            NodeNumbers = nodeNumbers;
        }

        //element stiffness method
    }
}
