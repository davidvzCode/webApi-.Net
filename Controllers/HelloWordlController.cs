using Microsoft.AspNetCore.Mvc;
using webApi.Services;

namespace webApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWordlController : ControllerBase
    {
        IHelloWordlService helloWordlService;
        
        TareasContext tareasContext;

        public HelloWordlController(IHelloWordlService helloWordl, TareasContext tareasContext)
        {
            helloWordlService = helloWordl;
            this.tareasContext = tareasContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(helloWordlService.GetHelloWordl());
        }
        [HttpGet]
        [Route("createdb")]
        public IActionResult CreateDataBase()
        {
            tareasContext.Database.EnsureCreated();
            return Ok();
        }
    }
}
