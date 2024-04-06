using GenericRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newsletter.Domain.Entities;
using Newsletter.Infrastucture.Context;
using Scrutor;

namespace Newsletter.Infrastucture;
internal static class DependencyInjection
{
    public static IServiceCollection AddInfrasturacture(
        this  IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseInMemoryDatabase(configuration.GetConnectionString("InMemory") ?? "");
        });

        services.AddIdentityCore<AppUser>().AddEntityFrameworkStores<ApplicationDbContext>();

        services.AddScoped<IUnitOfWork>(srv => srv.GetRequiredService<ApplicationDbContext>());

        services.Scan(action =>
        
             action
             .FromAssemblies(AppDomain.CurrentDomain.GetAssemblies())
             .AddClasses(publicOnly:false)
             .UsingRegistrationStrategy(RegistrationStrategy.Skip)
             .AsImplementedInterfaces()
             .WithScopedLifetime()
                      );
        

        return services;
    }
}
