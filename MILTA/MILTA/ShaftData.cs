using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryCore;
namespace MILTA
{
    internal class ShaftData
    {
        /// <summary>
        /// constructor 
        /// </summary>
        public ShaftData() { }
        public string Id { get; set; }=Guid.NewGuid().ToString();
        public CustomContourCollection InnerContours { get; set; } = new CustomContourCollection();
        public CustomContourCollection OuterContours { get; set; } = new CustomContourCollection();
        
        public List<EntityData> Edges { get { 
            List<EntityData> edges = new List<EntityData>();
                InnerContours.ForEach(x=>x.Edges.ForEach(y=>edges.Add(y)));
                OuterContours.ForEach(x=>x.Edges.ForEach(y => edges.Add(y)));
                return edges;
            } 
        }
    }
}
