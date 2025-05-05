using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent

    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke ()
        {
            var values = context.Abouts.ToList ();
            return View(values);


        }

      
          
    }
}
