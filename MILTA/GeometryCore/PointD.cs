using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    /// <summary>
    /// Point storage class in double.
    /// </summary>
    public class PointD
    {
        /// <summary>
        /// constructor
        /// </summary>
        public PointD() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y </param>
        public PointD(double x, double y)
        {
            X = x; Y = y;
        }
        private double _x; private double _y;
        public double X { get { return _x; } set { _x = value; } }
        public double Y { get { return _y; } set { _y = value; } }

        /// <summary>
        /// A class for creating a deep copy of PointD
        /// </summary>
        /// <returns>PointD object</returns>
        public PointD DeepCopy()
        {
            return new PointD(_x, _y);
        }
        /// <summary>
        /// A method for moving PointD object
        /// </summary>
        /// <param name="x">New X</param>
        /// <param name="y">New Y</param>
        /// <param name="changeBasePoint">If this argument is true changes base point otherwise return a deep copy of point object</param>
        /// <returns></returns>
        public PointD Move(double x, double y,bool changeBasePoint=false) {
            if (changeBasePoint)
            {
                _x = x;
                _y = y;
                return this;
            }
            else
            {
                return new PointD(x, y);
            }
        }
        /// <summary>
        /// Finds distance between two points.
        /// </summary>
        /// <param name="point">Target pointD object</param>
        /// <returns>Returns distance between the points.</returns>
        public double DistanceToPoint(PointD point)
        {
            double distance = double.NaN;
            double dx=point.X - this._x;
            double dy=point.Y - this._y;
            distance = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
            return distance;
        }
    }
}
