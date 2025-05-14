using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraciusProject.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [Authorize]
        [HttpGet("get-data")]
        public IActionResult GetData()
        {
            return Ok(new { result = true, message= "Başarılı" });
        }
    }
}
