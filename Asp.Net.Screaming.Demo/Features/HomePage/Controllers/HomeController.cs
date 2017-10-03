using Asp.Net.Screaming.Demo.Features.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net.Screaming.Demo.Features.HomePage.Controllers
{
    [Area(nameof(HomePage))]
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Error() => View(new ErrorViewModel
        {
            RequestId = "2"
        });
    }
}