using System;


namespace MiltaCore
{
    public class PointD
    {

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
        public double DistanceTo(PointD other)
        {
            return Math.Sqrt(Math.Pow(other.X - this.X, 2) +
                             Math.Pow(other.Y - this.Y, 2) +
                             Math.Pow(other.Z - this.Z, 2));
        }
        public double AngleToD(PointD other)
        {
            double dotProduct = _x * other.X + _y * other.Y + _z * other.Z;
            double magnitudeA = Math.Sqrt(_x * _x + _y * _y + _z * _z);
            double magnitudeB = Math.Sqrt(other.X * other.X + other.Y * other.Y + other.Z * other.Z);
            double cosTheta = dotProduct / (magnitudeA * magnitudeB);
            double angleRadians = Math.Acos(cosTheta);
            double angleDegrees = angleRadians * (180 / Math.PI);
            return angleDegrees;
        }
		public double AngleToR(PointD other)
		{
			return MiltaMath.ToRadian(AngleToD(other));
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
