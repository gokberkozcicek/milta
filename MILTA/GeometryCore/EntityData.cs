using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    /// <summary>
    /// Base class for drawing entities.
    /// </summary>
    public class EntityData
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual EntityTypesEnum Type { get; set; } = EntityTypesEnum.None;
        /// <summary>
        /// Returns vertices of entity.
        /// </summary>
        public virtual List<PointD> Vertices { 
            get { return new List<PointD>();} 
        }

    }
    public enum EntityTypesEnum
    {
        None,
        Line,
        Arc,
        Circle,
        ClosedPath
    }
}
