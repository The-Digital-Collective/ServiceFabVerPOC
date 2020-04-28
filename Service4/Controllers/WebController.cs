using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp1Service.Controllers
{
    class WebApp1
    {
        public String Name { get; set; }
        public int ID { get; set; }
    }
    [Route("api/[controller]")]
    public class WebController : Controller
    {
        List<WebApp1> weblist = new List<WebApp1>();
        public IActionResult Index()
        {
            weblist.Add(new WebApp1() { ID=1, Name = "Web1"});
            return new JsonResult(weblist);
         }
    }
}