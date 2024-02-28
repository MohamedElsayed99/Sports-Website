using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sports_Websites.Models;

namespace Sports_Websites.Controllers
{
	public class TournamentsController : Controller
	{
        SportsWebsitesContext SportsWebsitesCon;
        public TournamentsController()
        {
            SportsWebsitesCon = new SportsWebsitesContext();
        }
        public IActionResult Index()
		{
			// Replace with actual data retrieval logic later
			List<Tournament> tournaments = SportsWebsitesCon.Tournaments.ToList();
			return View(tournaments);
		}
		public IActionResult Create()
		{
			//List<Tournament> tournament = SportsWebsitesCon.Tournaments.ToList();
			return View(); // Return a view for creating a new tournament (form)
		}

		[HttpPost]
		public IActionResult Create(Tournament tournament)
		{
                // Save the tournament to the database
                SportsWebsitesCon.Tournaments.Add(tournament);
				SportsWebsitesCon.SaveChanges();
            
            return RedirectToAction("Index");
		}
		public IActionResult Edit(int id)
		{
			// Retrieve tournament data from the database (not implemented)
			//Tournament tournament = new Tournament(); 
			var tournment = SportsWebsitesCon.Tournaments.SingleOrDefault(x=>x.TournamentID == id);

			return View("Create",tournment);
		}

		[HttpPost]
		public IActionResult Edit(int id, Tournament tournament)
		{
            // Validate tournament data (not implemented)
            // Update the tournament data in the database (not implemented)
            var tournments = SportsWebsitesCon.Tournaments.SingleOrDefault(x => x.TournamentID == id);
            tournments.Name = tournament.Name;
			tournments.Description = tournament.Description;
			tournments.VideoURL = tournament.VideoURL;
			tournments.Logo = tournament.Logo;
			SportsWebsitesCon.SaveChanges();
            return RedirectToAction("Index");
		}
        public IActionResult Details(int id)
        {
            var tournament = SportsWebsitesCon.Tournaments.SingleOrDefault(t => t.TournamentID == id);
            
            return View(tournament);
        }

        public IActionResult Delete(int id)
		{
            var tournments = SportsWebsitesCon.Tournaments.SingleOrDefault(x => x.TournamentID == id);
			SportsWebsitesCon.Tournaments.Remove(tournments);
            SportsWebsitesCon.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
