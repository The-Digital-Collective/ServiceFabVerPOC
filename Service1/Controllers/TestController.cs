using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service1.Controllers
{
    class WebApp1
    {
        public String Name { get; set; }
        public int ID { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        List<WebApp1> weblist = new List<WebApp1>();
        public IActionResult Index()
        {
            weblist.Add(new WebApp1() { ID = 1, Name = "Web1" });
            return new JsonResult(weblist);
        }
    }
}