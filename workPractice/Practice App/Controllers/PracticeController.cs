using Microsoft.AspNetCore.Mvc;

namespace Practice_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracticeController : ControllerBase
    {
        public PracticeController() 
        {
            
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }
    }
}
