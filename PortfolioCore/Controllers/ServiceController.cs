using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ServiceController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult ServiceList()
        {
            var values = context.Services.ToList();
            return View(values);
        }

        public IActionResult DeleteService(int id)
        {
            var value = context.Services.Find(id);
            if (value != null)
            {
                context.Services.Remove(value);
                context.SaveChanges();
            }
            return RedirectToAction("ServiceList");
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            context.Services.Add(service);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = context.Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service p)
        {
            context.Services.Update(p);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

    }
}