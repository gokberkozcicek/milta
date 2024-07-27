using System;


namespace MiltaCore
{
    public class PointD
    {
		private int _number=0;

		public int Number
		{
			get { return _number; }
			set { _number = value; }
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

		public PointD() { }
		public PointD(double x, double y, double z)
		{
			_x = x;
			_y = y;
			_z = z;
		}

		public PointD DeepCopy()
		{
			return new PointD(_x, _y, _z);
		}
		public PointD Copy()
		{
			return DeepCopy();
		}
		public void Move(double x, double y, double z)
		{
			this._x = x;
			this._y = y;
			this._z = z;
		}
        public void AppendMove(double x, double y, double z)
        {
            this._x += x;
            this._y += y;
            this._z += z;
        }

  
		public bool IsEqual(PointD other,gxTolerances tolerance=gxTolerances.E4)
		{
			bool xEqual=MiltaMath.FuzzyEqual(_x, other.X, tolerance);
			bool yEqual=MiltaMath.FuzzyEqual(_y, other.Y, tolerance);
			bool zEqual=MiltaMath.FuzzyEqual(_z, other.Z, tolerance);
			return xEqual && yEqual && zEqual;
		}



     
    }
}
