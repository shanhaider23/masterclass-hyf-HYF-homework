using System;
using System.Collections.Generic;

namespace Week3.Models
{
    public class ConversionResponse
    {
        public double Value { get; set; }
        public string ValueType { get; set; }
        public List<ConversionResponse> ConvertValues(ConversionRequest Request)
        {

            List<ConversionResponse> response = new List<ConversionResponse>();


            if (Request.TypeToConvert == ConversionRequest.ValueType.Miles)
            {

                response.Add(new ConversionResponse
                {
                    Value = Request.Value,
                    ValueType = Request.TypeToConvert.ToString()
                });

                response.Add(new ConversionResponse
                {
                    Value = Request.Value * 1.609,
                    ValueType = (ConversionRequest.ValueType.Kilometeres).ToString()
                });


            }
            else if (Request.TypeToConvert == ConversionRequest.ValueType.Gallons)
            {
                response.Add(new ConversionResponse
                {
                    Value = Request.Value,
                    ValueType = Request.TypeToConvert.ToString()
                });
                response.Add(new ConversionResponse
                {
                    Value = Request.Value * 3.785412,
                    ValueType = (ConversionRequest.ValueType.Liters).ToString()
                });
            }

            else if (Request.TypeToConvert == ConversionRequest.ValueType.Pounds)
            {
                response.Add(new ConversionResponse { Value = Request.Value, ValueType = Request.TypeToConvert.ToString() });
                response.Add(new ConversionResponse { Value = Request.Value * 0.453, ValueType = (ConversionRequest.ValueType.Kilograms).ToString() });
            }

            else if (Request.TypeToConvert == ConversionRequest.ValueType.Yards)
            {
                response.Add(new ConversionResponse { Value = Request.Value, ValueType = Request.TypeToConvert.ToString() });
                response.Add(new ConversionResponse { Value = Request.Value * 0.914, ValueType = (ConversionRequest.ValueType.Meters).ToString() });
            }

            return response;
        }

    }
}