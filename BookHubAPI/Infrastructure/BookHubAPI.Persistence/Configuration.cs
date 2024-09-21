using Microsoft.Extensions.Configuration;

namespace BookHubAPI.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        { 
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/BookHubAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("PostgreSQL");
            } 
        }
    }
}
