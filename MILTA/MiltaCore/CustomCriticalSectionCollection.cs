using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class CustomCriticalSectionCollection:List<CriticalSectionData>
    {
        public new void Add(CriticalSectionData data)
        {
            base.Add(data);
            SetCriticalSections();
        }
        public void SetCriticalSections()
        {
            int i = 1;
            foreach (CriticalSectionData data in this)
            {

                data.Name = "CS-" + i.ToString();
                i++;
            }
        }
        public CriticalSectionData GetCriticalSectionById(string Id)
        {
            foreach (var item in this)
            {
                if (item.Id.Equals(Id))
                {
                    return item;
                }
            }
            return null;
        }
        public bool Highlight(string Id)
        {
            foreach (var item in this)
            {
                if (item.Id.Equals(Id))
                {
                    item.IsHighlighted = true;
                    return true;
                }
            }
            return false;

        }
    }
}
