using Web.Components;
using Infrastructure.DependencyInjection;
using Application.Services.Customers;
using Application.Services.Campaigns;
using Application.Services.SupportTickets;
using MudBlazor.Services;
using Application.Services.Identities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
.AddInteractiveServerComponents();

builder.Services.AddMudServices();

builder.Services.AddInfrastructureService(builder.Configuration);

builder.Services.AddScoped<ICustomerService , CustomerService>();
builder.Services.AddScoped<ICampaignService , CampaignService>();
builder.Services.AddScoped<ISupportTicketService, SupportTicketService>();
builder.Services.AddScoped<IIdentityService, IdentityService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
// Disable HTTPS redirection in development
if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}
//Add auth
app.UseAuthentication();
app.UseAuthorization();



app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
    

app.Run();
