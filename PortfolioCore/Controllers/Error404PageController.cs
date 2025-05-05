using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class Error404PageController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
