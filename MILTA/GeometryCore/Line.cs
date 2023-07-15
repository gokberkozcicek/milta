using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    /// <summary>
    /// A class for line entity.
    /// </summary>
    public class Line : EntityData
    {
        private PointD _startPoint; private PointD _endPoint; private double _length;
        /// <summary>
        /// Constructor
        /// </summary>
        public Line() {
            _startPoint = new PointD();
            _endPoint = new PointD();
        }
        /// <summary>
        /// Constructor with start and end point.
        /// </summary>
        /// <param name="startPoint">Start point as PointD object.</param>
        /// <param name="endPoint">End point as PointD object.</param>
        public Line(PointD startPoint, PointD endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }
        public override EntityTypesEnum Type { get; set; } = EntityTypesEnum.Line;
        public PointD StartPoint { get { return _startPoint; } set { _startPoint = value; } }
        public PointD EndPoint { get { return _endPoint; } set { _endPoint = value; } }
        public double Length { get { return StartPoint.DistanceToPoint(EndPoint); } }
        /// <summary>
        /// Returns vertices of line entity.
        /// </summary>
        public override List<PointD> Vertices
        {
            get { return new List<PointD>() { _startPoint, _endPoint }; }
        }
    }
}
