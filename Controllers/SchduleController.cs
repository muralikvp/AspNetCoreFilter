using Microsoft.AspNetCore.Mvc;

namespace filters.Controllers;

[ApiController]
[Route("[controller]")]
[MySampleActionFilterAttribute("Schdule")]
public class SchduleController : ControllerBase
{
    List<Schdule> lst_Schdule = new List<Schdule>();

    
    [HttpGet ("GetSchdule")]
    public  IEnumerable<Schdule> GetSchdule()
    {
       return lst_Schdule;
    }

    [HttpPost ("PostSchdule")]
    public string PostSchdule(Schdule _Schdule)
    {
        lst_Schdule.Add(_Schdule);
       return "Dotnet Core Student";
    }
}