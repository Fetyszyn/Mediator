using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.NetworkInformation;
using WebApplication2;


namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Interface _interface;
        public HomeController(ILogger<HomeController> logger, Interface ianterface)
        {
            _logger = logger;
            _interface = ianterface;
        }

        public IActionResult Index()
        {
            var name = _interface.getName();
            return Ok("this is name" + name);
        }

        public IActionResult Privacy()
        {
            return Ok();
        }

 
    }


   
}