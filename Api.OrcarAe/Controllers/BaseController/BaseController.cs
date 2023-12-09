using Microsoft.AspNetCore.Mvc;

namespace Api.OrcarAe.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<Model> : ControllerBase
        where Model : class
    {
        public BaseController()
        {
            
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("ok");
        }
        [HttpGet("Id:int")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Post()
        {
            return NoContent();
        }
        [HttpPut("id:int")]
        public IActionResult Put([FromBody] Model model)
        {
            return NoContent();
        }
        [HttpDelete("id:int")]
        public IActionResult Delete()
        {
            return NoContent();
        }

    }
}
