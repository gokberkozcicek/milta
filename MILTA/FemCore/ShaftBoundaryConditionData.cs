using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FemCore
{
    internal class ShaftBoundaryConditionData
    {
		private int _nodeNumber;
		public int NodeNumber
		{
			get { return _nodeNumber; }
			set { _nodeNumber = value; }
		}

		public BoundaryCondition boundaryCondition = BoundaryCondition.None;


	}

	public enum BoundaryCondition 
	{
	Free,
	Fixed,
	None
	}
}
