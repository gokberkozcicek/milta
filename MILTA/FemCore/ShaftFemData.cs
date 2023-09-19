using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FemCore
{
    public class ShaftFemData
    {

        private int _numberOfElement;

        public int NumberOfElement
        {
            get { return _numberOfElement; }
            set { _numberOfElement = value; }
        }

        private int NumberOfNode
        {
            get { return NumberOfElement + 1; }
        }

        private double _elasticModulus;

        public double ElasticModulus
        {
            get { return _elasticModulus; }
            set { _elasticModulus = value; }
        }

        private double _shearModulus;

        public double ShearModulus
        {
            get { return _shearModulus; }
            set { _shearModulus = value; }
        }



        private double _ElementLength;

        public double ElementLength
        {
            get { return _ElementLength; }
            set { _ElementLength = value; }
        }



        public CustomShaftSectionCollection ShaftSectionDatas = new CustomShaftSectionCollection();









    }
}
