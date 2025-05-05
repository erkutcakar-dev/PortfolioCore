using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultSkillStatsComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.Skill1 = context.Testimonials.Count();
            ViewBag.Skill2 = context.Portfolios.Count();
            ViewBag.Skill3 = context.Skills.Count();

            Random rnd = new Random();
            ViewBag.skill1 = rnd.Next(9, 21);
            ViewBag.skill2 = rnd.Next(9, 21);
            ViewBag.skill3 = rnd.Next(9, 21);
            ViewBag.skill4 = rnd.Next(9, 21);

            return View();
        }
    }
}