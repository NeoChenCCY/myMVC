using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmploessController: Controller
    {
        private readonly ILogger<HomeController> _logger;

        public EmploessController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index4()
        {

            emploess emp = new Models.emploess();
            emp.EmpID = 121564654;
            emp.UserName = "我是小老師";

            

            return View(emp);
        }

        public IActionResult Index5() 
        {
            List<emploess> Myemplist = new List<emploess>
            {   new Models.emploess{ UserName = "我是小老師01" },
                new Models.emploess{ UserName = "我是小老師02" },
                new Models.emploess{ UserName = "我是小老師03" },
                new Models.emploess{ UserName = "我是小老師04" },
                new Models.emploess{ UserName = "我是小老師05" },
            };

            return View(Myemplist);
        }
    }
}
