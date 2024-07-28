using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public abstract class BcInput : INotifyPropertyChanged
    {
        public virtual object Value { get; set; }=double.NaN;

        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify(string propertyName, object oldValue, object newValue, string Id)
        {
            OnPropertyChanged(this, new ExtendedPropertyChangedEventArgs(propertyName, oldValue, newValue, Id));

        }
        public virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(sender, e);
        }
        public override string ToString()
        {
            if (Value.Equals(double.NaN))
            {
                return "Unconstrained";
            }
            else if (Value.Equals(double.PositiveInfinity))
            {
                return "Fixed";
            }
            else
            {
                return Value.ToString();
            }
        }
    }
    public class ValueInput:BcInput
    {
        public override object Value { get; set; } = 0;
    }
    public class UnconstrainedValue : BcInput
    {
        public override object Value { get; set; } = double.NaN;
    }
    public class FixedValue : BcInput
    {
        public override object Value { get; set; } = double.PositiveInfinity;
    }
}
