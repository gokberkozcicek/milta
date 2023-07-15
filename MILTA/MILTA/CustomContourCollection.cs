using GeometryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILTA
{
    /// <summary>
    /// A custom collection class for contours.
    /// </summary>
    internal class CustomContourCollection:List<ShaftContourData>
    {
        public new void Add(ShaftContourData data)
        {
            base.Add(data);
            SetContourStartPoints();
        }
        private void SetContourStartPoints()
        {
            PointD startPoint=new PointD(0,0);
            foreach (ShaftContourData contour in this)
            {
                contour.StartPoint = startPoint.DeepCopy();
                startPoint.X = startPoint.X + contour.StartOffset + (contour.Length);
                contour.SetGeometryEntities();
            }
        }
    }
}
