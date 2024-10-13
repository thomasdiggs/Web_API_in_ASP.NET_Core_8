
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dependency_Injection_Demo.Services;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IDemoService _demoService;

        public DemoController(IDemoService demoService)
        {
            _demoService = demoService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Content(_demoService.SayHello());
        }
    }
}
