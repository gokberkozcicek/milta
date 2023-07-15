using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    public class ClosedPath
    {
        private List<EntityData> _entities;
        public ClosedPath() { }
        public ClosedPath(List<EntityData> entities)
        {
            _entities = entities;
        }
    }
}
