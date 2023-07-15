using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    public static class AnalyticalCalculations
    {
        public static PointD GetCenterPointsOfPointList(List<PointD> points)
        {
            double xAll = 0; double yAll = 0;
            double number = points.Count;
            foreach (PointD point in points)
            {
                xAll += point.X;
                yAll += point.Y;
            }
            return new PointD(xAll/number, yAll / number);
        }
    }
}
