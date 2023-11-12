using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebraCore
{
    public class PointD
    {
		public PointD() { }
		public PointD(double x, double y, double z) {
			this._x = x; this._y = y; this._z = z;
		}
		private double _x;

		public double X
		{
			get { return _x; }
			set { _x = value; }
		}

		private double _y;

		public double Y
		{
			get { return _y; }
			set { _y = value; }
		}

        private double _z;

        public double Z
        {
            get { return _z; }
            set { _z = value; }
        }
    }
}
