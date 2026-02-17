using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Infrastructure.Data;
using Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Identity
{
    public static class Authentication
    {

    public static IServiceCollection AddAuthenticationService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(options =>

        {
            options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
            options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
            options.DefaultScheme = IdentityConstants.ApplicationScheme;            
        })
        .AddIdentityCookies();

        services.AddIdentityCore<User>(options =>
        { 
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = true;
            options.Password.RequiredLength = 6;
            options.Password.RequiredUniqueChars = 1;

            options.User.RequireUniqueEmail = true;

            options.SignIn.RequireConfirmedAccount= true;
            options.Lockout.MaxFailedAccessAttempts = 5;

        })
        .AddRoles<IdentityRole<int>>()
          .AddEntityFrameworkStores<ApplicationDbContext>()
          .AddSignInManager()
          .AddDefaultTokenProviders();

          services.Configure<DataProtectionTokenProviderOptions>(options =>
          {
              options.TokenLifespan = TimeSpan.FromHours(6);
          });

          services.ConfigureApplicationCookie(options =>
          {
            options.Cookie.Name= "CRMDemo";
            options.Cookie.HttpOnly = true;
            options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
            options.Cookie.SameSite = SameSiteMode.Lax;
             
          });           
       

            return services;
    }
}
}