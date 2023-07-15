using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    public class ClosedPath:EntityData
    {
        private List<EntityData> _entities;
        public ClosedPath() { }
        public ClosedPath(List<EntityData> entities)
        {
            _entities = entities;
        }
        public List<EntityData> Edges { get { return _entities; } }
        public override List<PointD> Vertices
        {
            get
            {
                List<PointD> vertices = new List<PointD>();
                _entities.ForEach(x => x.Vertices.ForEach(y => vertices.Add(y)));
                return vertices;
            }
        }
        public override EntityTypesEnum Type { get; set; } = EntityTypesEnum.ClosedPath;
        public BoundingBox BoundingBox { get { return new BoundingBox(Vertices); } }
    }
}
