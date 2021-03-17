using HotReloadTestApps.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HotReloadTestApps.WPF.Converters
{
    public class DotNetReleaseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DotNetRelease release)
            {

                // bad code
               //release.Description.Contains("2.0")
               //return "2.0!";
                
                // good code
                if (release.Description.Contains("2.0"))
                {
                    return "2.0!";
                }
            }

            return "not 2.0";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
