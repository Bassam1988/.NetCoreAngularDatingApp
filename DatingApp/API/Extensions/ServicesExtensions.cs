using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IHelperClass, HelperClass>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddCors();
            return services;
        }
    }
}
