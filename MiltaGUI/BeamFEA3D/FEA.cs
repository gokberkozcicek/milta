using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebraCore;
namespace BeamFEA3D
{
    public class FEA
    {
        public FEA() { }

        public NodeCollection Nodes=new NodeCollection();
        public ElementCollection Elements=new ElementCollection();

        public void Solve()
        {
            //solve codes will be here.
        }
    }
}
