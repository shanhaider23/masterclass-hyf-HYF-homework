using Microsoft.AspNetCore.Mvc;

namespace week3.Controllers;

[ApiController]
[Route("[controller]")]

public class ConverterContoller : ControllerBase
{
    public class Distance
    {
        public int Miles { get; set; }
        public double Kilometers { get; set; }
    }

    [HttpGet("CoverMileage")]
    public double ConvertMilage(int milesPerGallon)
    {
        return milesPerGallon * 3.7854;
    }

    [HttpGet("ConvertMiles")]
    public Distance ConvertMiles(int miles)
    {
        double km = miles * 1.609;
        return new Distance() { Miles = miles, Kilometers = km };
    }

    [HttpPost("convert")]
    public List<ConversionResponse> ConvertValues([FromBody] ConversionRequest Request)
    {
        return new ConversionResponse().ConvertValues(Request);
    }
}