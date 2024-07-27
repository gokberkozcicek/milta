using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public interface IMiltaComponent
    {
        MiltaComponentTypes ComponentTypes { get; set; }
    }
    public enum MiltaComponentTypes
    {
        Shaft
    }
}
