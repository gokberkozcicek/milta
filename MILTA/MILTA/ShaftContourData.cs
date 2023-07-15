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
       
        public virtual double Length { get; set; } = 30;
        public PointD StartPoint { get; set; } = new PointD();
        public double StartOffset { get; set; } = 0;
        public virtual List<PointD> Vertices { get; set; }
        public virtual List<EntityData> Edges { get; set; }
        public virtual ClosedPath ClosedPath { get; }
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
