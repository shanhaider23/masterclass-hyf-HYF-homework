using System;

namespace Week3.Models
{
    public class ConversionRequest
    {
        public double Value { get; set; }
        public ValueType TypeToConvert { get; set; }

        public enum ValueType
        {
            Miles,
            Kilometeres,
            Gallons,
            Liters,
            Pounds,
            Kilograms,
            Yards,
            Meters
        }
    }

}