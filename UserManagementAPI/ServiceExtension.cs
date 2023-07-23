using Microsoft.EntityFrameworkCore;
using Models;

namespace UserManagementAPI
{
    public static class ServiceExtension
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyDbContext>(
                opts => opts.UseSqlServer(configuration.GetConnectionString("DatabaseConnectionString")));
        }
            
    }
}
