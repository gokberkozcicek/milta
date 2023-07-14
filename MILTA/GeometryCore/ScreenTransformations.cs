using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    /// <summary>
    /// A class for coordinate transformations.
    /// </summary>
    public class ScreenTransformations
    {   
        private List<PointD> _points = new List<PointD>();
        public double ScreenWidth { get; set; }
        public double ScreenHeight { get; set; }
        public float ZoomFactor { get; set; }
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
        /// <summary>
        /// constructor
        /// </summary>
        public ScreenTransformations() { }
        
        

    }
}
