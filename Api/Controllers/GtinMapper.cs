using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class GtinMapperController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private Dictionary<Tuple<string,string>, string> mappingTable;  

    private readonly ILogger<GtinMapperController> _logger;

    public GtinMapperController(ILogger<GtinMapperController> logger)
    {
        _logger = logger;
        mappingTable = new Dictionary<Tuple<string, string>, string>();

    }

    [HttpPut(Name = "GenerarateEGGin")]
    public string PUT(String storeId, string localGtin)
    {
        if(mappingTable.ContainsKey(new Tuple<string,string>(storeId, localGtin)))
          return mappingTable.GetValueOrDefault(new Tuple<string,string>(storeId, localGtin));
        
        return  "12344";
    }
}
