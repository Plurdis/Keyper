using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Keyper.Converters
{
    public class PasswordHashingConverter : ValueConverter<string, string>
    {
        public override string Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            return HashingPassword(value);
        }


        string HashingPassword(string password)
        {
            var data = Encoding.ASCII.GetBytes(password);

            var sha1 = new SHA1CryptoServiceProvider();
            byte[] sha1data = sha1.ComputeHash(data);
            var asciiEncoding = new ASCIIEncoding();

            string hashingPassword = asciiEncoding.GetString(sha1data);

            return hashingPassword;
        }


        public override string ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new SecurityException("해싱된 패스워드는 복구할 수 없습니다.");
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
