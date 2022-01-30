using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab06WPFAPP
{
    class WeatherControl : DependencyObject
    {
        public static readonly DependencyProperty TemperatureProperty = DependencyProperty.Register(
      nameof(Temperature),
      typeof(int),
      typeof(WeatherControl),
      new FrameworkPropertyMetadata(
          0,
          FrameworkPropertyMetadataOptions.AffectsMeasure |
          FrameworkPropertyMetadataOptions.AffectsRender,
          null,
          new CoerceValueCallback(CoerceTemperature)),
      new ValidateValueCallback(ValidateTemperature));

        private static bool ValidateTemperature(object value)
        {
            int v = (int)value;
            if (v >= -50 && v <= 50)
                return true;
            else
                return false;
        }

        private static object CoerceTemperature(DependencyObject d, object baseValue)
        {
            int v = (int)baseValue;
            if (v >= -50 && v <= 50)
                return v;
            else
                return 0;
        }

        public int Temperature
        {
            get => (int)GetValue(TemperatureProperty);
            set => SetValue(TemperatureProperty, value);
        }

        public string windDirection;
        public int windSpeed;

        public enum Precipitation
        {
            солнечно = 0,
            облачно = 1,
            дождь = 2,
            снег = 3
        }
    }
}
