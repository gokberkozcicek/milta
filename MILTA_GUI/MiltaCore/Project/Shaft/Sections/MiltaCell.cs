using MiltaCore.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class MiltaCell
    {
        public int Number { get; set; } = 0;
        public string Id { get; set; }=Guid.NewGuid().ToString();
        public PointDCollection Points;
        public MiltaCell() { 
            Points = new PointDCollection();
        }
        

    }
}
