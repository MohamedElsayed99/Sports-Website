using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace Sports_Websites.Models
{
    // SportsWebsites.cs
    public class SportsWebsitesContext : DbContext
	{
        public SportsWebsitesContext(DbContextOptions<SportsWebsitesContext> options) : base(options)
		{
		}
        public SportsWebsitesContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SportsWebsite2;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Team> Teams { get; set; }
		public DbSet<Tournament> Tournaments { get; set; }
		public DbSet<Match> Matches { get; set; }
		public DbSet<TeamTournamentMapping> TeamTournamentMappings { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TeamTournamentMapping>()
				.HasKey(tt => new { tt.TeamID, tt.TournamentID });

			modelBuilder.Entity<TeamTournamentMapping>()
				.HasOne(tt => tt.Team)
				.WithMany(t => t.TeamTournamentMappings)
				.HasForeignKey(tt => tt.TeamID);

			modelBuilder.Entity<TeamTournamentMapping>()
				.HasOne(tt => tt.Tournament)
				.WithMany(t => t.TeamTournamentMappings)
				.HasForeignKey(tt => tt.TournamentID);
		}

	}


}
