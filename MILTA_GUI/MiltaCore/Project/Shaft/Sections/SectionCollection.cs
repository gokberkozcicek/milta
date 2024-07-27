using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore.Sections
{
    public class SectionCollection : List<SectionData>, IMiltaObject
    {
        public string Id { get; set; }=Guid.NewGuid().ToString();
        public string Name { get; set; } = "Section Collection";
        public MiltaObjectTypes MiltaObjectType { get; set; } = MiltaObjectTypes.SectionCollection;

        public new void Add(SectionData sectionData)
        {
            base.Add(sectionData);
            SetPoints();
        }
        public OuterSection AddDummyOuterSection()
        {
            OuterSection section = new OuterSection(30,30,20);
            Add(section); return section;
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
                    x += section.length;
                }
                else
                {
                    section.StartPoint = new PointD(x, 0, 0);
                    x += section.length;
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
