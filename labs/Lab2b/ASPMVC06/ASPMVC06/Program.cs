using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

#pragma warning disable ASP0014 
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "M01",
        pattern: "{controller=TMResearch}/{action=M01}/{str?}");

    endpoints.MapControllerRoute(
        name: "M02",
        pattern: "V2/{controller}/{action}",
        defaults: new { controller = "TMResearch", action = "M02" });

    endpoints.MapControllerRoute(
        name: "M03",
        pattern: "V3/{controller}/{str?}/{action}",
        defaults: new { controller = "TMResearch", action = "M03" });

    endpoints.MapControllerRoute(
        name: "MXX",
        pattern: "{*uri}",
        defaults: new { controller = "TMResearch", action = "MXX" });

});
#pragma warning restore ASP0014 // Suggest using top level route registrations

app.Run();
