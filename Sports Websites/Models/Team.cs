namespace Sports_Websites.Models
{
	// Team.cs
	public class Team
	{
		public int TeamID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string OfficialWebsiteURL { get; set; }
		public string Logo { get; set; }
		public DateTime? FoundationDate { get; set; }

		public List<TeamTournamentMapping> TeamTournamentMappings { get; set; }
	}


}
