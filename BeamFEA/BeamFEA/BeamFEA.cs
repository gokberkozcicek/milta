using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamFEA
{
    public class BeamFEA
    {
        public BeamFEA() { }

        public Dictionary<int,FeNode> Nodes { get; set; }=new Dictionary<int, FeNode>();
        public Dictionary<int, FeElement> Elements { get; set; } = new Dictionary<int, FeElement>();

        public bool Solve()
        {
            return true;
        }
    }
}
