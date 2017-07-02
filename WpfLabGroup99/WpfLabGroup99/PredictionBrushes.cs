using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfLabGroup99
{
    public class PredictionBrushes : IValueConverter
    {
        public object Convert(object value, Type targetType, object
        parameter, System.Globalization.CultureInfo culture)
        {
            var getIntensity = (TrafficIntensities)value;
            switch (getIntensity)
            {
                case TrafficIntensities.Light:
                    return Brushes.LightGreen;
                case TrafficIntensities.Medium:
                    return Brushes.LightYellow;
                case TrafficIntensities.Heavy:
                    return Brushes.MediumVioletRed;
                case TrafficIntensities.Congested:
                    return Brushes.IndianRed;
                case TrafficIntensities.Blockage:
                    return Brushes.Red;
            }
            return Binding.DoNothing;
        }
        public object ConvertBack(object value, Type targetType,
        object parameter, System.Globalization.CultureInfo culture)
        {
            var getIntensity = (TrafficIntensities)value;
            switch (getIntensity)
            {
                case TrafficIntensities.Light:
                    return Brushes.LightGreen;
                case TrafficIntensities.Medium:
                    return Brushes.LightYellow;
                case TrafficIntensities.Heavy:
                    return Brushes.MediumVioletRed;
                case TrafficIntensities.Congested:
                    return Brushes.IndianRed;
                case TrafficIntensities.Blockage:
                    return Brushes.Red;
            }
            return Binding.DoNothing;

        }

    }

}
