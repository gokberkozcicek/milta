using GeometryCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    /// <summary>
    /// Base class for items in which are used shaft calculation like,force,contours,force etc.
    /// </summary>
    public class ShaftItemData
    {
        [Browsable(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual string Name { get; set; }
        [Browsable(false)]
        public PointD StartPoint { get; set; } = new PointD();
        public virtual double LocationX { get; set; } = 0;
        public bool IsHighlighted { get; set; } = false;
    }
}
