using NETFEA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class MaterialCollection:BindingList<Material>
    {
        public MaterialCollection() { }
        public new void Add(Material material)
        {
            base.Add(material);
        }
    }
}
