using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EShop.Infrastructure.Persistance;

namespace EShop.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("Postgresql")));

        return services;
    }
}
