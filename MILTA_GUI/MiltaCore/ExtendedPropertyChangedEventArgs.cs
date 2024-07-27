using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class ExtendedPropertyChangedEventArgs:PropertyChangedEventArgs
    {
     
        public string Id { get; set; }
        public object OldValue { get; set; }
        public object NewValue { get; set; }
        public ExtendedPropertyChangedEventArgs(string propertyName,object oldValue, object newValue,string id) 
            : base(propertyName)
        {
            Id = id;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
