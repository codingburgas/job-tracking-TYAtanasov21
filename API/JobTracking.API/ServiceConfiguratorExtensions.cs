using JobTracking.Application.Interfaces;
using JobTracking.Application.Services;
using JobTracking.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace JobTracking.API
{
    public static class ServiceConfiguratorExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IJobService, JobService>();
            return services;
        }
    }
}
