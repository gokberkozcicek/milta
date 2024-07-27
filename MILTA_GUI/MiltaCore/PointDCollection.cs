using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore.Math
{
    public class PointDCollection:List<PointD>
    {
        int i = 0;
        public new void Add(PointD point)
        {
            if (!ContainsPoint(point))
            {
                i++;
                point.Number = i;
                
                base.Add(point);
            }
        }
        public bool ContainsPoint(PointD point,out PointD outPoint)
        {
            foreach (var item in this)
            {
                if (item.IsEqual(point))
                {
                    outPoint = item;
                    return true;
                }
            }
            outPoint = null;
            return false;
        }
        public bool ContainsPoint(PointD point)
        {
            foreach (var item in this)
            {
                if (item.IsEqual(point))
                {
                    return true;

                }
            }
            return false;
        }


    }
}
