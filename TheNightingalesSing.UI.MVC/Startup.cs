using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TheNightingalesSing.BLL.Concrete.DependecyInjection;
using TheNightingalesSing.UI.MVC.Models.Cart;
using TheNightingalesSing.UI.MVC.Helper;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace TheNightingalesSing.UI.MVC
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScopeBLL();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(a => a.LoginPath = new PathString("/Account/Login"));
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();
            app.Use((httpContext, nextMiddleware) =>
            {
                httpContext.Session.Set<MyCart>("cart", new MyCart());
                return nextMiddleware();
            });

            app.UseAuthentication();

            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas", 
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Home}/{action=index}/{id?}");
            });
        }
    }
}
