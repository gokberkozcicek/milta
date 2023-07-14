using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILTA
{
    /// <summary>
    /// Base class for items in which are used shaft calculation like,force,contours,force etc.
    /// </summary>
    internal class ShaftItemData
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual string Name { get; set; }
    }
}
