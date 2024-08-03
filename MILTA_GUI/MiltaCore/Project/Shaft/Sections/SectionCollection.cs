using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore.Sections
{
    public class SectionCollection : List<SectionData>, IMiltaObject
    {
        public IMiltaObject ParentObject { get; set; }
        public string Id { get; set; }=Guid.NewGuid().ToString();
        public string Name { get; set; } = "Section Collection";
        public MiltaObjectTypes MiltaObjectType { get; set; } = MiltaObjectTypes.SectionCollection;
        public SectionCollection(IMiltaObject parentObject)
        {
            ParentObject = parentObject;
        }
        public new void Add(SectionData sectionData)
        {
            sectionData.ParentObject = this;
            base.Add(sectionData);
            SetPoints();
        }
        public OuterSection AddDummyOuterSection()
        {
            OuterSection section = new OuterSection(30,30,20);
            section.ParentObject = this;
            Add(section); return section;
        }
        public void RemoveItem(SectionData sectionData)
        {
            this.RemoveAll(x=> x.Id == sectionData.Id);

        }
        private void SetPoints()
        {
            int i = 0;
            double x = 0;
            foreach (var section in this)
            {
                if (i==0)
                {
                    section.StartPoint = new PointD(0, 0, 0);
                    x += section.Length;
                }
                else
                {
                    section.StartPoint = new PointD(x, 0, 0);
                    x += section.Length;
                }
                i++;
            }
        }
        public CellCollection GetCells()
        {
            CellCollection cells = new CellCollection();
            foreach (var section in this)
            {
                foreach (var cell in section.GetCells())
                {
                    cells.Add(cell);
                }
            }
            return cells;
        }
    }
}
