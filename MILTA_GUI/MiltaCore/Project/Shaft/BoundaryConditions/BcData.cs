using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class BcData : IMiltaObject,INotifyPropertyChanged
    {
        [Browsable(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual string Name { get; set; } = "BC";
        public double Location { get; set; } = 0;
        [Browsable(false)]
        public virtual MiltaObjectTypes MiltaObjectType { get; set; } = MiltaObjectTypes.BC;
        [Browsable(false)]
        public IMiltaObject ParentObject { get; set; }
        [TypeConverter(typeof(BcInputTypeConverter))]
        public BcInput Ux { get; set; }
        [TypeConverter(typeof(BcInputTypeConverter))]
        public BcInput Uy { get; set; }
        [TypeConverter(typeof(BcInputTypeConverter))]
        public BcInput Uz { get; set; }
        [TypeConverter(typeof(BcInputTypeConverter))]
        public BcInput Rx { get; set; }
        [TypeConverter(typeof(BcInputTypeConverter))]
        public BcInput Ry { get; set; }
        [TypeConverter(typeof(BcInputTypeConverter))]
        public BcInput Rz { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public BcData()
        {
            Ux = new UnconstrainedValue();
            Uy = new UnconstrainedValue();
            Uz = new UnconstrainedValue();
            Rx = new UnconstrainedValue();
            Ry = new UnconstrainedValue();
            Rz = new UnconstrainedValue();
            Ux.PropertyChanged += PropertyChanged;
            Uy.PropertyChanged += PropertyChanged;
            Uz.PropertyChanged += PropertyChanged;
            Rx.PropertyChanged += PropertyChanged;
            Ry.PropertyChanged += PropertyChanged;
            Rz.PropertyChanged += PropertyChanged;
        }
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
       
    }
}
