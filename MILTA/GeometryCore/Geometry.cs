using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCore
{
    /// <summary>
    /// A class for geometry definition.
    /// </summary>
    public class Geometry
    {
        private CustomEntityCollection _entityCollection = new CustomEntityCollection();
        private CoordinateTransformer CoordinateTransformer { get; set; }=new CoordinateTransformer();
        /// <summary>
        /// constructor
        /// </summary>
        public Geometry() {}

        #region CoordinateTransformations
        public int ScreenWidth { get { return CoordinateTransformer.ScreenWidth; } set { CoordinateTransformer.ScreenWidth = value; } }
        public int ScreenHeight { get { return CoordinateTransformer.ScreenHeight; } set { CoordinateTransformer.ScreenHeight = value; } }
        public float OffsetX { get { return CoordinateTransformer.OffsetX; } set { CoordinateTransformer.OffsetX = value; } }
        public float OffsetY { get { return CoordinateTransformer.OffsetY; } set { CoordinateTransformer.OffsetY = value; } }
        public float StartPanX { get { return CoordinateTransformer.StartPanX; } set { CoordinateTransformer.StartPanX = value; } }
        public float StartPanY { get { return CoordinateTransformer.StartPanY; } set { CoordinateTransformer.StartPanY = value; } }
        public float ZoomFactor { get { return CoordinateTransformer.ZoomFactor; } set { CoordinateTransformer.ZoomFactor = value; } }
        public PointD MouseBeforeZoom { get { return CoordinateTransformer.MouseBeforeZoom;} set { CoordinateTransformer.MouseBeforeZoom = value; } }
        public PointD MouseAfterZoom { get { return CoordinateTransformer.MouseAfterZoom; } set { CoordinateTransformer.MouseAfterZoom = value; } }
        public PointD ToWorld(PointF point)
        {
            return CoordinateTransformer.ToWorld(point);
        }
        public PointF ToScreen(PointD point)
        {
            return CoordinateTransformer.ToScreen(point);
        }
        public List<PointD> ZoomPoints { get; set; }
        public void ZoomFit()
        {
            CoordinateTransformer.Vertices = ZoomPoints;
            CoordinateTransformer.ZoomFit();
        }
        #endregion

        /// <summary>
        /// A method for adding an entity.
        /// </summary>
        /// <param name="entity">Takes EntityData as an argument.</param>
        public void AddEntity(EntityData entity)
        {
            _entityCollection.Add(entity);
        }
        public CustomEntityCollection Entities { get { return _entityCollection; } }
    }
}
