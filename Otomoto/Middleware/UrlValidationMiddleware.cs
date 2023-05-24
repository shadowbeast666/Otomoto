using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Other service configurations...

        services.AddRouting();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            // Define your routes here
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Add a catch-all route for handling 404 errors
            endpoints.MapFallback(HandleNotFound);
        });
    }

    private Task HandleNotFound(HttpContext context)
    {
        context.Response.StatusCode = 404;
        // Optionally, you can return a custom 404 page
        // by writing the appropriate HTML content to the response.
        // Example:
        // await context.Response.WriteAsync("404 - Page Not Found");
        return Task.CompletedTask;
    }
}
