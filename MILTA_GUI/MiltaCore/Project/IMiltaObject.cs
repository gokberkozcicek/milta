using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public interface IMiltaObject
    {
        string Id { get; set; }
        string Name { get; set; }
        MiltaObjectTypes MiltaObjectType {  get; set; }
        IMiltaObject ParentObject { get; set; }
    }
    public enum MiltaObjectTypes
    {
        MiltaProject,
        Shaft,
        ShaftCollection,
        Section,
        SectionCollection,
        Force,
        Moment,
        LoadCollection
    }
}
