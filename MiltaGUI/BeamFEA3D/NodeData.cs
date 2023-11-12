using LinearAlgebraCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamFEA3D
{
    public class NodeData
    {
		public NodeData() { }

		private string _id;

		public string Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private int _number;

		public int Number
		{
			get { return _number; }
			set { _number = value; }
		}

		private PointD _location;

		public PointD Location
		{
			get { return _location; }
			set { _location = value; }
		}


	}
}
