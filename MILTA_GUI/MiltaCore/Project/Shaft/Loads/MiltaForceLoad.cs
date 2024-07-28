using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class MiltaForceLoad:MiltaLoad
    {
        public override string Name { get; set; } = "Force";
        public override MiltaObjectTypes MiltaObjectType { get; set; } = MiltaObjectTypes.Force;
        [Browsable(false)]
        public BindingList<ForceInput> Inputs { get; set; }

        public MiltaForceLoad() { }
        public MiltaForceLoad(double location,double fx, double fy, double fz)
        {
            Location = location;
            Inputs = new BindingList<ForceInput>();
            ParentObject = null;
        }
        public void AddDummyForceInput(int step=1)
        {
            ForceInput forceInput = new ForceInput(step, 0, 0, 0);
            forceInput.PropertyChanged += this.OnPropertyChanged;
            Inputs.Add(forceInput);
        }
    }
}
