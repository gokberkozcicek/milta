using MiltaCore.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public abstract class SectionData : IMiltaObject,INotifyPropertyChanged
    {
        [Browsable(false)]
        public string Id {get;set;}=Guid.NewGuid().ToString();
        public virtual string Name { get; set; } = "Section";
        [Browsable(false)]
        public virtual MiltaObjectTypes MiltaObjectType { get; set; }
        private double _lentgh=20;
        public double Length
        {
            get { return _lentgh; }
            set { 
                var oldValue= _lentgh;
                _lentgh = value;
                Notify("LENGTH",oldValue,_lentgh,Id);
            }
        }

        [Browsable(false)]
        public PointD StartPoint { get; set; }
        [Browsable(false)]
        public virtual SectionTypes SectionType { get; set; }
        [Browsable(false)]
        public IMiltaObject ParentObject { get; set; }
        public virtual List<MiltaCell> GetCells()
        {
            return null;
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
    public enum SectionTypes
    {
        Outer,
        Inner
    }
}
