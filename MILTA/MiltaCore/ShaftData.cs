using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryCore;
namespace MiltaCore
{
    public class ShaftData
    {
        /// <summary>
        /// constructor 
        /// </summary>
        public ShaftData() { }
        [Browsable(false)]
        public string Id { get; set; }=Guid.NewGuid().ToString();
        [Browsable(false)]
        public CustomContourCollection InnerContours { get; set; } = new CustomContourCollection();
        [Browsable(false)]
        public CustomContourCollection OuterContours { get; set; } = new CustomContourCollection();
        [Browsable(false)]
        public CustomBearingCollection Bearings { get; set; } = new CustomBearingCollection();
        [Browsable(false)]
        public CustomLoadCollection Loads { get; set; } = new CustomLoadCollection();
        [Browsable(false)]
        public CustomCriticalSectionCollection CrticalSections { get; set; } = new CustomCriticalSectionCollection();
        [Browsable(false)]
        public List<EntityData> Edges { get { 
            List<EntityData> edges = new List<EntityData>();
                InnerContours.ForEach(x=>x.Edges.ForEach(y=>edges.Add(y)));
                OuterContours.ForEach(x=>x.Edges.ForEach(y => edges.Add(y)));
                return edges;
            }
            set { }
        }
        public BoundingBox BoundingBox { get {
                BoundingBox bb = new BoundingBox(this.Vertices);
                bb.SetBoundingBox();
                return bb;
            } set { } }
        public ShaftContourData GetContourById(string Id)
        {
            if (InnerContours.GetContourById(Id)!=null)
            {
                return InnerContours.GetContourById(Id);
            }
            if (OuterContours.GetContourById(Id) != null)
            {
                return OuterContours.GetContourById(Id);
            }
            return null;
        }
        public void UpdateItems()
        {
            InnerContours.UpdateContours();
            OuterContours.UpdateContours();
            Bearings.UpdateAllBearings();
            Loads.UpdateAllLoads();
        }
        public void UnHighlightAll()
        {
            InnerContours.ForEach(x=>x.IsHighlighted = false);
            OuterContours.ForEach(x=>x.IsHighlighted = false);
            CrticalSections.ForEach(x=>x.IsHighlighted = false);
            Loads.ForEach(x=>x.IsHighlighted = false);

            Bearings.ForEach(x=>x.IsHighlighted = false);
        }
        public void HightlightAllShaft()
        {
            OuterContours.ForEach(x => x.IsHighlighted = true);
            InnerContours.ForEach(x => x.IsHighlighted = true);
            Bearings.ForEach(x => x.IsHighlighted = true);
            Loads.ForEach(x => x.IsHighlighted = true);
        }
        public bool Hightlight(string Id)
        {
            if (InnerContours.Highlight(Id))
            {
                return true;
            }
            if (OuterContours.Highlight(Id))
            {
                return true;
            }
           
            if (Loads.Highlight(Id)) { 
                return true;
            }
            if (CrticalSections.Highlight(Id)) { 
                return true;
            }

            return false;
        }
        public BearingData GetBearingById(string Id)
        {
            return Bearings.GetBearingById(Id);
        }
    public CriticalSectionData GetCriticalSectionById(string Id)
        {
            return CrticalSections.GetCriticalSectionById(Id);
        }
   
        public LoadData GetLoadById(string Id) {
        return Loads.GetLoadById(Id);
        }
        [Browsable(false)]
        public List<PointD> Vertices
        {
            get
            {
                List<PointD> vertices = new List<PointD>();
                OuterContours.Vertices.ForEach(x=> vertices.Add(x));
                InnerContours.Vertices.ForEach(x=> vertices.Add(x));
                return vertices;
            }
            set
            {

            }
        }
        public double Length { get { return OuterContours.Length; }set { } }
    }
}
