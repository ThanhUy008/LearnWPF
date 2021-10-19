using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MobilePhones
{
    class ToVNDConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string vnd = value.ToString();
            int lastIndex = vnd.IndexOf('.') - 1;
            int loopTimes;
            string presiousEnd = "";
            vnd = vnd.Replace(".", ",");
            if (lastIndex < 0)
            {
                lastIndex = vnd.Length - 1;
            }
            loopTimes = lastIndex;
            for (int i = 0; i < (loopTimes) / 3; i++)
            {
                string tempLast = vnd.Substring(lastIndex - 2, 3);
                presiousEnd = "." + tempLast + presiousEnd;
                string tempFirst = vnd.Substring(0, lastIndex - 2);
                vnd = tempFirst + presiousEnd;
                lastIndex -= 3;
            }
            return $"{vnd} VND";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


}
