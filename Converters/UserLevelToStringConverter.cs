using Keyper.Users;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyper.Converters
{
    class UserLevelToStringConverter : ValueConverter<UserLevel, string>
    {
        public override string Convert(UserLevel value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case UserLevel.SuperAdministrator:
                    return "최고 관리자";
                case UserLevel.Administrator:
                    return "관리자";
                case UserLevel.User:
                    return "사용자";
                default:
                    return "알 수 없는 유저";
            }
        }

        public override UserLevel ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case "최고 관리자":
                    return UserLevel.SuperAdministrator;
                case "관리자":
                    return UserLevel.Administrator;
                case "사용자":
                    return UserLevel.User;
                default:
                    return UserLevel.Unknown;
            }
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
