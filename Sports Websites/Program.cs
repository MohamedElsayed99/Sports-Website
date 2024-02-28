using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Sports_Websites.Models;

namespace Sports_Websites
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>(); 
				});
	}
}
