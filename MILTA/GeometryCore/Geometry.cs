using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    /// <summary>
    /// A class for geometry definition.
    /// </summary>
    public class Geometry
    {
        private CustomEntityCollection _entityCollection = new CustomEntityCollection();
        /// <summary>
        /// constructor
        /// </summary>
        public Geometry() {}
        
        /// <summary>
        /// A method for adding an entity.
        /// </summary>
        /// <param name="entity">Takes EntityData as an argument.</param>
        public void AddEntity(EntityData entity)
        {
            _entityCollection.Add(entity);
        }
    }
}
