using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamFEA3D
{
    public class NodeCollection:List<NodeData>
    {
        public new void Add(NodeData node)
        {
            base.Add(node);
        }
    }
}
