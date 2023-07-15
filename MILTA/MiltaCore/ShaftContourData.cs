using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryCore;

namespace MiltaCore
{
    public class ShaftContourData:ShaftItemData
    {
        /// <summary>
        /// constructor 
        /// </summary>
        public ShaftContourData() { }
        [Browsable(false)]
        public virtual ContourTypesEnum ContourType { get; set; } = ContourTypesEnum.None;
        [Browsable(false)]
        public virtual ContourShapesEnum ContourShape { get; set; } = ContourShapesEnum.None;
       
        public virtual double Length { get; set; } = 30;
       
        [Browsable(false)]
        public double StartOffset { get; set; } = 0;
        [Browsable(false)]
        public virtual List<PointD> Vertices { get; set; }
        [Browsable(false)]
        public virtual List<EntityData> Edges { get; set; }
        [Browsable(false)]
        public virtual ClosedPath ClosedPath { get; set; }
        public virtual void SetGeometryEntities() { }
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
