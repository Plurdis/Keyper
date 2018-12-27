using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyper.Converters
{
    public class boolToRentalTextConverter : ValueConverter<bool, string>
    {
        public override string Convert(bool value, Type targetType, object parameter, CultureInfo culture)
        {
            return value ? "대여중" : "대여 가능";
        }

        public override bool ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == "대여중" ? true : false;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
