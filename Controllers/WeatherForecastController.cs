using Microsoft.AspNetCore.Mvc;

namespace filters.Controllers;


[ApiController]
[Route("[controller]")]
[MySampleActionFilterAttribute("Weather ForeCast")]

public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

   // [ResourceFileAttribute("Res Weather")]
    //[ServiceFilter(typeof(SampleResultFilterAttribute))]
   // [TypeFilter(typeof(SampleResultFilterAttribute),Arguments = new object[]{"Action"})]
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

  [HttpGet ("GetStudentData")]
    public string GetStudentData()
    {
       return "Dotnet Core Student";
    }

    

   
}
