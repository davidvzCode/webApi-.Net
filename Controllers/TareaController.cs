using Microsoft.AspNetCore.Mvc;
using webApi.Models;
using webApi.Services;

namespace webApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TareaController: ControllerBase
    {

        ITareaService tareaService;

        public TareaController(ITareaService tareaService)
        {
            this.tareaService = tareaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(tareaService.Get());
        }
    }
}
