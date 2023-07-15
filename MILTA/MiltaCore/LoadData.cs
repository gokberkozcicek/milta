using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class LoadData:ShaftItemData
    {
        public virtual LoadTypesEnum Type { get; set; }= LoadTypesEnum.None;
        public virtual void SetLoads()
        {
            StartPoint=new GeometryCore.PointD(0,0).Move(LocationX,0);
        }
    }
    public enum LoadTypesEnum
    {
        None,
        Force,
        Moment,
        Torque
    }
}
