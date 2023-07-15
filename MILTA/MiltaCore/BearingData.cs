using GeometryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class BearingData:ShaftItemData
    {
        public virtual double OuterDiameter { get; set; } = 40;
        public virtual double InnerDiameter { get; set; } = 20;
        public virtual double Thickness { get; set; } = 10;
        public BearingTypesEnum BearingType { get; set; } = BearingTypesEnum.None;
        public virtual List<PointD> Vertices { get; set; }

        public virtual List<ClosedPath> ClosedPaths { get; set; }=new List<ClosedPath>();
        public virtual void SetBearing() { }
    }
    public enum BearingTypesEnum
    {
        None = 0,
        BallBearing,
        RollerBearing,
        ThrustBearing,
        SleeveBearing,
        TaperedRollerBearing,
        CylindricalRollerBearing,
        NeedleRollerBearing,
        AngularContactBearing,
        SelfAligningBearing,
        SphericalRollerBearing,
        LinearBearing,
        Custom
    }
}
