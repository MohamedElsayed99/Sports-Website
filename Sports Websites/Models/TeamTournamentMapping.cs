namespace Sports_Websites.Models
{
	// TeamTournamentMapping.cs
	public class TeamTournamentMapping
	{
		public int TeamID { get; set; }
		public Team Team { get; set; }

		public int TournamentID { get; set; }
		public Tournament Tournament { get; set; }
	}

}
