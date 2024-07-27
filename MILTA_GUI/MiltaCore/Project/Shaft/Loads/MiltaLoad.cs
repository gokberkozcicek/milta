using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public abstract class MiltaLoad : IMiltaObject, INotifyPropertyChanged
    {
        [Browsable(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual string Name { get; set; } = "Load";
        public double Location { get; set; } = 0;
        [Browsable(false)]
        public virtual MiltaObjectTypes MiltaObjectType { get; set; }

        [Browsable(false)]
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
    }
}
