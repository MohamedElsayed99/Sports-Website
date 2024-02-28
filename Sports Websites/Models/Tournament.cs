namespace Sports_Websites.Models
{
	// Tournament.cs
	public class Tournament
	{
		public int TournamentID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Logo { get; set; }
		public string VideoURL { get; set; }

		public List<TeamTournamentMapping> TeamTournamentMappings { get; set; }
	}


}
