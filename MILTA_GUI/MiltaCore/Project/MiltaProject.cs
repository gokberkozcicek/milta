using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class MiltaProject : IMiltaObject
    {
        [Browsable(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [ReadOnly(true)]
        public virtual string Name { get; set; } = "Milta Project";
        [Browsable(false)]
        public virtual MiltaObjectTypes MiltaObjectType { get; set; }=MiltaObjectTypes.MiltaProject;
        [Browsable(false)]
        public ShaftCollection ShaftCollection;
        private int _step =5;

        public int StepCount
        {
            get { return _step; }
            set {
                var oldValue = _step;
                _step = value;
                Notify("STEPNUMBER", oldValue, _step, Id);
            }
        }
        [Browsable(false)]
        public IMiltaObject ParentObject { get; set; }
        public MiltaProject() {
            ShaftCollection = new ShaftCollection(this);
            ParentObject = null;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propertyName, object oldValue, object newValue, string Id)
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
