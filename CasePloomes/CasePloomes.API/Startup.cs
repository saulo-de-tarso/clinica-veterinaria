using CasePloomes.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CasePloomes.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Retrieve connection string from appsettings.json
            string connectionString = Configuration.GetConnectionString("CasePloomesConnectionString");

            // Add DbContext to DI container
            services.AddDbContext<CasePloomesDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Other service registrations...
        }
    }
}
