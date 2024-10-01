using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Gymany.Core.Service;
using Microsoft.Extensions.Options;
using Gymany.Core.Common; 

namespace Gymany
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            
            // Register the ApiService with HttpClient for making HTTP requests.
            services.AddHttpClient<ApiService>();

            // Bind the ApiSettings section from appsettings.json to the ApiSettings class.
            services.Configure<ApiSettings>(Configuration.GetSection("ApiSettings"));

            // Register ApiSettings as a singleton service to be used throughout the application.
            services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<ApiSettings>>().Value);

            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();
            services.AddSession((option) =>
            {
                option.Cookie.Name = "Username";
                option.Cookie.Name = "Email";

                option.IdleTimeout = new TimeSpan(0, 30, 0);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {   
                 endpoints.MapAreaControllerRoute(
                    name: "PTPage",
                    pattern: "{controller}/{action=Index}/{id?}",
                    areaName: "PT"
                );
                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    pattern: "{controller}/{action=Index}/{id?}",
                    areaName: "Admin"
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
