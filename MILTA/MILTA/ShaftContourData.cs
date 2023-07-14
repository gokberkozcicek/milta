using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryCore;

namespace MILTA
{
    internal class ShaftContourData:ShaftItemData
    {
        /// <summary>
        /// constructor 
        /// </summary>
        public ShaftContourData() { }
        public virtual ContourTypesEnum ContourType { get; set; } = ContourTypesEnum.None;
        public virtual ContourShapesEnum ContourShape { get; set; } = ContourShapesEnum.None;
        public PointD StartLocation { get; set; }=new PointD();
    }
    /// <summary>
    /// Enum for inner outer contour definition. 
    /// </summary>
    public enum ContourTypesEnum
    {
        None,
        Inner,
        Outer
    }
    /// <summary>
    /// Enum for definition of contour shape.
    /// </summary>
    public enum ContourShapesEnum
    {
        None,
        Cylinder,
        Cone,
        Hexagon
    }
}
