using System;
using System.Collections.Generic;

namespace MiltaCore
{
    public class MiltaMath
    {
        public static double ToRadian(double angle)
        {
            return angle * (System.Math.PI / 180);
        }
        public static double ToDegree(double radian)
        {
            return radian * (180/ System.Math.PI);
        }
        public static bool FuzzyEqual(double a, double b, gxTolerances tolerance=gxTolerances.E4)
        {
            return System.Math.Abs(a - b) < GetTolerance(tolerance);
        }
        public static bool IsZero(double a, gxTolerances tolerance = gxTolerances.E4)
        {
            return FuzzyEqual(a,0,tolerance);
        }
        private PointD GetCenterPoint(params PointD[] points)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            double len=points.Length;
            if (len.Equals(0))
            {
                return null;
            }
            foreach (var point in points)
            {
                x += point.X;
                y += point.Y;
                z += point.Z;
            }
            return new PointD(x/len,y/len,z/len);

        }
        private PointD GetCenterPoint(List<PointD> points)
        {
            return GetCenterPoint(points.ToArray());
        }
        private static double GetTolerance(gxTolerances tolerance)
        {
            double value = 1e-4;
            switch (tolerance)
            {
                case gxTolerances.E1:
                    value = 1e-1;
                    break;
                case gxTolerances.E2:
                    value = 1e-2;
                    break;
                case gxTolerances.E3:
                    value = 1e-3;
                    break;
                case gxTolerances.E4:
                    value = 1e-4;
                    break;
                case gxTolerances.E5:
                    value = 1e-5;
                    break;
                case gxTolerances.E6:
                    value = 1e-6;
                    break;
                default:
                    break;
            }
            return value;
        }
    }
    public enum gxTolerances
    {
        E1, E2, E3,E4, E5, E6
    }
}
