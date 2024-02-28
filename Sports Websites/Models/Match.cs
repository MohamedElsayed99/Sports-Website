namespace Sports_Websites.Models
{
	// Match.cs
	public class Match
	{
		public int MatchID { get; set; }
		public DateTime MatchDate { get; set; }

		public int TournamentID { get; set; }
		public Tournament Tournament { get; set; }

		public int Team1ID { get; set; }
		public Team Team1 { get; set; }

		public int Team2ID { get; set; }
		public Team Team2 { get; set; }
	}

}
