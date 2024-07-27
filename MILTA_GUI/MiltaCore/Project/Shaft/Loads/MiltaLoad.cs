using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public abstract class MiltaLoad : IMiltaObject
    {
        [Browsable(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual string Name { get; set; } = "Load";
        public double Location { get; set; } = 0;
        [Browsable(false)]
        public virtual MiltaObjectTypes MiltaObjectType { get; set; }

    }
}
