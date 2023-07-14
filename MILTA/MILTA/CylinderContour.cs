using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILTA
{
    /// <summary>
    /// A class for cylindrical contour definition.
    /// </summary>
    internal class CylinderContour:ShaftContourData
    {
        private double _diameter;
        private double _length;
        /// <summary>
        /// constructor
        /// </summary>
        public CylinderContour() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="diameter">Dimater</param>
        /// <param name="length">Contour length</param>
        public CylinderContour (double diameter, double length)
        {
            _diameter= diameter;
            _length= length; 
        }
        public double Diameter { get { return _diameter; } set { _diameter = value;} }
        public double Length { get { return _length; } set { _length = value;} }
        public override string Name { get; set; } = "Cylinder";
        public override ContourShapesEnum ContourShape { get; set; }= ContourShapesEnum.Cylinder;
    }
}
