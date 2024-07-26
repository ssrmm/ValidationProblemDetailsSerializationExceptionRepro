using Microsoft.AspNetCore.Mvc;

namespace WebApplication1;

[ApiController]
[Route("[controller]")]
public class EchoController : ControllerBase
{
    [HttpGet]
     public ActionResult Get([FromQuery] string content)
     {
         if (content.Contains("goodbye", StringComparison.OrdinalIgnoreCase))
         {
             // We don't like goodbyes!
             return BadRequest();
         }

         if (content.Contains("secret", StringComparison.OrdinalIgnoreCase))
         {
             return Unauthorized();
         }

         return Ok(content);

     }
}
