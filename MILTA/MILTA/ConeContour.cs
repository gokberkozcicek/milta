using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MILTA
{
    internal class ConeContour:ShaftContourData
    {
        private double _d1, _d2,_length;
        /// <summary>
        /// constructor
        /// </summary>
        public ConeContour() { }    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d1">Start diameter</param>
        /// <param name="d2">End diameter</param>
        /// <param name="length">contour length</param>
        public ConeContour(double d1, double d2,double length) {
            _d1 = d1;
            _d2 = d2;
            _length = length;
        }
        public double D1 { get { return _d1; } set { _d1 = value; } }
        public double D2 { get { return _d2; } set { _d2 = value; } }
        public double Length { get { return _length; } set { _length = value; } }
    }
}
