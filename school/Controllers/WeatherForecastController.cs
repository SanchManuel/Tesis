using Microsoft.AspNetCore.Mvc;

namespace school.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Selena", "Dana", "Emma" };
    }
}
