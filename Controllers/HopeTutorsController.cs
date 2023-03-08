using Microsoft.AspNetCore.Mvc;

namespace filters.Controllers;

[ApiController]
[Route("[controller]")]
  [MySampleActionFilterAttribute("Controller level Hope Tutors")]
public class HopeTutorsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<HopeTutorsController> _logger;

    public HopeTutorsController(ILogger<HopeTutorsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTraining")]
    //  [MySampleAsyncActionFilterAttribute("Get Method Level")]
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

    
}
