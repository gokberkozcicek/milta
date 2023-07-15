using GeometryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    /// <summary>
    /// A custom collection class for contours.
    /// </summary>
    public class CustomContourCollection:List<ShaftContourData>
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
        public ShaftContourData GetContourById(string Id)
        {
            foreach (var item in this)
            {
                if (item.Id.Equals(Id))
                {
                    return item;
                }
            }
            return null;
        }
        public void UpdateContours() {
            SetContourStartPoints();
        }
        public List<PointD> Vertices { 
            get { 
            List<PointD> points = new List<PointD>();
                foreach (var item in this)
                {
                    item.Vertices.ForEach(x=>points.Add(x));
                }
                return points;
            }
            set { }
        }
        public double Length { get { 
            double length = 0;
                foreach (var item in this)
                {
                    length += item.Length;
                }
                return length;
            }set { } }
        public bool Highlight(string Id)
        {
            foreach (var item in this)
            {
                if (item.Id.Equals(Id))
                {
                    item.IsHighlighted = true;
                    return true;
                }
            }
            return false;
     
        }
    }
}
