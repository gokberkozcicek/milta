using MiltaCore.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class CellCollection:List<MiltaCell>
    {
        public PointDCollection Points=new PointDCollection();
        int index = 0;
        public new void Add(MiltaCell cell)
        {
            for (int i = 0; i < cell.Points.Count; i++)
            {
                if (Points.ContainsPoint(cell.Points[i],out PointD resultPoint))
                {
                    cell.Points[i] = resultPoint;
                }
                else
                {
                    Points.Add(cell.Points[i]);
                }
            }
            cell.Number= index++;
            base.Add(cell);
        }
    }
}
