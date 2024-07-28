using System;
using System.ComponentModel;
using System.Globalization;

namespace MiltaCore
{
    public class BcInputTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            return base.CanConvertFrom(context, sourceType);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string strValue)
            {
                strValue=strValue.ToUpper();
                if (strValue.Equals("FIXED")|| strValue.Equals("FIX"))
                {
                    return new FixedValue();
                }
                else if (strValue.Equals("UNCONSTRAINED") || strValue.Equals("UD")|| strValue.Equals("NA"))
                {
                    return new UnconstrainedValue();
                }
          
                else
                {
                    bool isDouble = double.TryParse(strValue, out double result);
                    ValueInput valueInput = new ValueInput();
                    valueInput.Value = 0;
                    if (isDouble)
                    {
                        valueInput.Value = result;
                    }
                    else
                    {
                        return new UnconstrainedValue();
                    }
                    return valueInput;
                }

                
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
                return true;
            return base.CanConvertTo(context, destinationType);
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is BcInput bcInput)
            {
                return bcInput.ToString(); 
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}

