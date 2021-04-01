using Microsoft.AspNetCore.Mvc;
using SharpenTheSaw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpenTheSaw.Components
{
    //TeamNameViewComponent to give collect the necessary data for the partial view
    public class TeamNameViewComponent : ViewComponent
    {
        private BowlingLeagueContext _context;
        public TeamNameViewComponent (BowlingLeagueContext ctx)
            {
            _context = ctx;
            }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["TeamName"];

            return View(_context.Teams
                .Distinct()
                .OrderBy(x=>x));
        }
    }
}
