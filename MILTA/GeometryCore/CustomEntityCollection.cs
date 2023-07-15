using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    /// <summary>
    /// A custtom collection class for entities. 
    /// </summary>
    public class CustomEntityCollection:List<EntityData>
    {
        public new void Add(EntityData item)
        {
            base.Add(item);
        }
        public new void Clear() { base.Clear();}
        public List<PointD> Vertices
        {
            get {
                List<PointD> points = new List<PointD>();
                foreach (var item in this)
                {
                    item.Vertices.ForEach(x => points.Add(x.DeepCopy()));
                }
                return points;
            }
            
        }
    }
}
