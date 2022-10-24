using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.initData;
using RichnessSoft.Service.BS;
using RichnessSoft.Web2.Services;
using RichnessSoft.Web2.Data;
using RichnessSoft.Service;
using RichnessSoft.Service.Store;
using RichnessSoft.Entity.Model;
using Blazored.SessionStorage;
using RichnessSoft.Service.Logs;
using RichnessSoft.Common;



var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);
ConfigurationManager Configuration = builder.Configuration;

builder.Services.AddDbContext<RicnessDbContext>(options => options
    .UseNpgsql(Configuration["RicnessErp:ConnectionString"])
    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
    .EnableSensitiveDataLogging(false)
    .EnableServiceProviderCaching(true)
    .EnableDetailedErrors(true), ServiceLifetime.Transient);
builder.Services.AddDbContext<RichnessLogDbContext>(options => options.UseNpgsql(Configuration["RicnessErp:ConnectionString_log"]).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking), ServiceLifetime.Transient);
gbVar.MainConstr = Configuration["RicnessErp:ConnectionString"];
gbVar.LogConstr = Configuration["RicnessErp:ConnectionString_log"];

// Add services to the container.
builder.Services.AddBlazoredSessionStorage(config => config.JsonSerializerOptions.WriteIndented = true);
builder.Services.AddSweetAlert2();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ProfileStore>();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();
builder.Services.AddScoped<IFunctional, Functional>();
builder.Services.AddScoped<DataHelper>();
builder.Services.AddScoped<IUserLoginService, UserLoginService>();

builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
builder.Services.AddScoped<AuthStateProvider>();
builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<IUmService, UmService>();
builder.Services.AddScoped<IOrderTranService, OrderTranService>();
builder.Services.AddScoped<IBranchService, BranchService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IPdGroupService, PdGroupService>();
builder.Services.AddScoped<IColorService, ColorService>();
builder.Services.AddScoped<IDesignService, DesignService>();
builder.Services.AddScoped<IGradeService, GradeService>();
builder.Services.AddScoped<IWarehouseService, WarehouseService>();
builder.Services.AddScoped<ICustGroupsService, CustGroupService>();
builder.Services.AddScoped<ISaleAreaService, SaleAreaService>();
builder.Services.AddScoped<IBankService, BankService>();


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyAllowSpecificOrigins",
      builder =>
      {
          builder.AllowAnyOrigin();
          builder.AllowAnyHeader();
          builder.AllowAnyMethod();
      });
});

// Configure Languate
builder.Services.AddLocalization(options => { options.ResourcesPath = "Resources"; });
var supportedCultures = new[] { "en-US", "th-TH" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[1])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

var app = builder.Build();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

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
// Configure Languate
app.UseRequestLocalization(localizationOptions);

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();