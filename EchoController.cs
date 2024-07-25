using Microsoft.AspNetCore.Mvc;

namespace WebApplication1;

[ApiController]
[Route("[controller]")]
public class EchoController : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] string content)
    {
        return Ok(content);
    }
}
