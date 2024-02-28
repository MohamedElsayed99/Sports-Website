using Microsoft.AspNetCore.Mvc;
using Sports_Websites.Models;

namespace Sports_Websites.Controllers
{
	public class TeamsController : Controller
	{
		SportsWebsitesContext _context;
        public TeamsController()
        {
            
			_context = new SportsWebsitesContext();
        }
        // Index action to display a list of all teams
        public IActionResult Index()
		{

			List<Team> teams = _context.Teams.ToList();
			return View(teams);
		}

		// Create action to handle adding a new team
		public IActionResult Create()
		{
			// Return a view for creating a new team (form)

			return View();
		}

		// Logic to handle form submission for creating a new team (not implemented)
		[HttpPost]
		public IActionResult Create(Team team)
		{

			_context.Teams.Add(team);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		// Edit action to retrieve and display an existing team for editing
		public IActionResult Edit(int id)
		{

			// Retrieve team data from the database 
			Team team = _context.Teams.SingleOrDefault(x=>x.TeamID==id);
			return View("Create",team);
		}

		// Logic to handle form submission for updating an existing team (not implemented)
		[HttpPost]
		public IActionResult Edit(int id, Team team)
		{
            Team teams = _context.Teams.SingleOrDefault(x => x.TeamID == id);
			teams.Name = team.Name;
			teams.Description = team.Description;
			teams.OfficialWebsiteURL = team.OfficialWebsiteURL;
			teams.Logo=team.Logo;
			teams.FoundationDate = team.FoundationDate;
			_context.SaveChanges();
            return RedirectToAction("Index");
		}

		// Delete action to handle deleting a team
		public IActionResult Delete(int id)
		{
            // Retrieve team data from the database 
            Team team = _context.Teams.SingleOrDefault(x => x.TeamID == id);
			_context.Teams.Remove(team);
			_context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Logic to handle confirmation for deleting a team (not implemented)
        [HttpPost]
		public IActionResult DeleteConfirmed(int id)
		{
			// Delete the team from the database (not implemented)
			return RedirectToAction("Index");
		}
	}
}
