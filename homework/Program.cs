using homework.Areas.Identity;
using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.backEnd.Interfaces.MainInterface;
using homework.backEnd.Repositories.ClassifiesRepos;
using homework.backEnd.Repositories.MainRepos;
using homework.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();



/// ---- HR interfaces & repo ------

builder.Services.AddScoped<IEmploye,EmployRepos>();
builder.Services.AddScoped<IOffice,OfficeRepos>();
builder.Services.AddScoped<IDepartment, DepartmentRepo>();
builder.Services.AddScoped<IAdministrativeStand, AdministrativeStandRepos>();
builder.Services.AddScoped<ICertificate, CertificateClassifyRepos>();
builder.Services.AddScoped<IDocumentSubject, DocumentSubjectRepos>();
builder.Services.AddScoped<IDocumentType, DocumentTypeRepos>();
builder.Services.AddScoped<IEmpStates, EmpStatesRepos>();
builder.Services.AddScoped<IGeoLocation, GeoLocationRepos>();
builder.Services.AddScoped<IJobLocation, JobLocationRepos>();
builder.Services.AddScoped<IGovernorate, GovernorateRepos>();
builder.Services.AddScoped<IJobDegree, JobDegreeRepos>();
builder.Services.AddScoped<ILanguage, LanguageRepos>();
builder.Services.AddScoped<IMaritalStatus, MaritalStatusRepos>();
builder.Services.AddScoped<INationalism, NationalismRepos>();
builder.Services.AddScoped<INationality, NationalityRepos>();
builder.Services.AddScoped<IOccupation, OccupationRepos>();
builder.Services.AddScoped<IPosition, PositionRepos>();
builder.Services.AddScoped<IReligion, ReligionRepos>();
builder.Services.AddScoped<IService, ServiceRepos>();
builder.Services.AddScoped<IServiceStatus, ServiceStatusRepos>();
builder.Services.AddScoped<IServiceType, ServiceTypeRepos>();
builder.Services.AddScoped<ISpecialization, SpecializationRepo>();
builder.Services.AddScoped<IStage, StageRepos>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
