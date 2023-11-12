using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamFEA3D
{
    public class ElementData
    {
        public ElementData() { }
        public ElementData(NodeData n1, NodeData n2) { 
        this._n1 = n1; this._n2 = n2;
        }

		private NodeData _n1;

		public NodeData N1
		{
			get { return _n1; }
			set { _n1 = value; }
		}

        private NodeData _n2;

        public NodeData N2
        {
            get { return _n2; }
            set { _n2 = value; }
        }

        //add element stiffness calculation here.
    }
}
