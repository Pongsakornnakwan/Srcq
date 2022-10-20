using Blazored.LocalStorage;
using Blazored.Modal;
using Blazored.SessionStorage;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.initData;
using RichnessSoft.Service.Store;
using RichnessSoft.Web.Data;
using RichnessSoft.Web.Services;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddDbContext<RicnessDbContext>(options => options.UseSqlServer(Configuration["RicnessErp:ConnectionString"]
 ,providerOptions => providerOptions.EnableRetryOnFailure())
.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
, ServiceLifetime.Transient);

builder.Services.AddDbContext<RichnessLogDbContext>(options => options.UseSqlServer(Configuration["RicnessErp:ConnectionString_log"]).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking), ServiceLifetime.Transient);

builder.Services.AddDevExpressBlazor(); 
builder.Services.AddSweetAlert2();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
builder.Services.AddScoped<AuthStateProvider>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredModal();
pmethAddBusinessServices( builder.Services);

// Configure Languate
builder.Services.AddLocalization(options => { options.ResourcesPath = "Resources"; });
var supportedCultures = new[] { "en-US", "th-TH" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
IConfiguration configuration = app.Configuration;
IWebHostEnvironment environment = app.Environment;
using (var scope = app.Services.CreateScope())
{
    SuperAdminDefaultOptions superAdminDefaultOptions = Configuration.GetSection("SuperAdminDefaultOptions").Get<SuperAdminDefaultOptions>();
    var context = scope.ServiceProvider.GetRequiredService<RicnessDbContext>(); 
    var contextLog = scope.ServiceProvider.GetRequiredService<RichnessLogDbContext>(); 

    DBinitializer.InitializeAsync(context, contextLog, superAdminDefaultOptions);
}
app.UseHttpsRedirection();


app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
// Configure Languate
app.UseRequestLocalization(localizationOptions);

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();


void pmethAddBusinessServices(IServiceCollection services)
{
    services.AddScoped<ProfileStore>();
    services.AddScoped<RichnessSoft.Service.QueryData>();
}