using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class AboutController : Controller
    {

        PortfolioContext context = new PortfolioContext();
        public IActionResult AboutList()
        {

            var values = context.Abouts.ToList();
            return View(values);
        }

        public IActionResult DeleteAbout (int id)
        {

            var values = context.Abouts.Find(id);
             context.Abouts.Remove(values);
            context.SaveChanges();
            return  RedirectToAction("AboutList");
           
        }
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();    

        }

        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");

        }


        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About p)
        {
            var value = context.Abouts.Update(p);
            context.SaveChanges();
            return RedirectToAction("AboutList");

        }


    }
}
