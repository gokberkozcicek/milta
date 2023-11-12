using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamFEA3D
{
    public class ResultData
    {
        public ResultData() { }
        public ResultTypesEnum ResultType { get; set; } = ResultTypesEnum.None;
    }

    public enum ResultTypesEnum
    {
        Nodal,
        Elemental,
        None
    }
}
