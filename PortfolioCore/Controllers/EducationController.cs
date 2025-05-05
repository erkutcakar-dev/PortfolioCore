using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class EducationController : Controller
    {

        PortfolioContext context = new PortfolioContext();
        public IActionResult EducationList()

        {
            var values = context.Educations.ToList();
            return View(values);
        }

        public IActionResult DeleteEducation(int id)
        {

            var value = context.Educations.Find(id);
            context.Educations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("EducationList");

        }

        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();

        }
        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            if (!ModelState.IsValid)
            {
                return View(education); 
            }

            context.Educations.Add(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }

        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var values = context.Educations.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateEducation(Education p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }

            context.Educations.Update(p);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
    }
