using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SendMessageController : Controller
    {

        PortfolioContext context = new PortfolioContext();  
        public IActionResult SendMessage(Message p)
        {
            context.Messages.Add(p);
            context.SaveChanges();
            ViewBag.Success = "Mesaj Başarı İle Gönderildi";
            return View("~/Views/Default/Index.cshtml");
        }
    }
}
