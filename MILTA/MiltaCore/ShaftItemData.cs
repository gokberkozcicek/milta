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
    }
}
