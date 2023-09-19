using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FemCore
{
    public class ShaftSectionData:ShaftFemData
    {

        private double _shaftDiameter;

        public double ShaftDiameter
        {
            get { return _shaftDiameter; }
            set { _shaftDiameter = value; }
        }


        public double PolarInertia
        {
            get { return Math.PI * Math.Pow(ShaftDiameter, 4) / 32; }
        }


        public double ShearConstantKv
        {
            get { return PolarInertia; }

        }

        public double CrossSectionArea
        {
            get { return Math.PI * Math.Pow(ShaftDiameter, 2) / 4; }
        }

        public double SectionInertia
        {
            get { return Math.PI * Math.Pow(ShaftDiameter, 4) / 64; }

        }


    }
}
