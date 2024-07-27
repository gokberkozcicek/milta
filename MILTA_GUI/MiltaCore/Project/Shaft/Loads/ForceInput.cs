using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class ForceInput:INotifyPropertyChanged
    {
        public string Id { get; set; }=Guid.NewGuid().ToString();
        public int StepNumber { get; set; } = 0;
        private double _fx = 0;
        public double Fx
        {
            get { return _fx = 0; }
            set { 
                var oldValue = _fx;
                _fx = value;
                Notify("fx", oldValue, _fx, Id);
            
            }
        }

        private double _fy = 0;
        public double Fy
        {
            get { return _fy = 0; }
            set
            {
                var oldValue = _fy;
                _fy = value;
                Notify("fy", oldValue, _fy, Id);

            }
        }

        private double _fz = 0;
        public double Fz
        {
            get { return _fz = 0; }
            set
            {
                var oldValue = _fz;
                _fz = value;
                Notify("fz", oldValue, _fz, Id);

            }
        }
        public ForceInput(int stepNumber, double fx, double fy, double fz)
        {
            StepNumber = stepNumber;
            _fx = fx;
            _fy = fy;
            _fz = fz;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify(string propertyName,object oldValue,object newValue,string Id)
        {
            OnPropertyChanged(this, new ExtendedPropertyChangedEventArgs(propertyName, oldValue, newValue,Id));
        
        }
        public virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(sender, e);
        }

    }
}
