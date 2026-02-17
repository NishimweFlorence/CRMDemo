using Application.Interfaces;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Identity;
using Infrastructure.Data;
using Application.Services.Identities;

namespace Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Data.ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("CRMDemoMSSQLConnection")));
            
            //Register identity services
            services.AddAuthenticationService(configuration);



            //Register Repositories


           

            services.AddScoped<ICustomer , CustomerRepository>();
            services.AddScoped<ICampaign , CampaignRepository>();
            services.AddScoped<ISupportTicket , SupportTicketRepository>(); 
            services.AddScoped<IIdentity, IdentityRepos>();
          

            return services;
        }
    }
}