using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CqSheep.RazorSample.Repositories;
using CqSheep.RazorSample.Repositories.Entity;
using CqSheep.RazorSample.Repositories.Interfaces;
using CqSheep.RazorSample.Services;
using CqSheep.RazorSample.Services.Interfaces;
using CqSheep.Utils.Repository.ColumnMapperCommon;
using CqSheep.Utils.Repository.MySqlDatabase;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CqSheep.RazorSample.Host
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = new PathString("/Admin/Login");
                options.ExpireTimeSpan = TimeSpan.FromDays(3);
            });
            //Configuration.GetSection("");
            services.AddSingleton<IUserRepository, UserRepository>( r=> new UserRepository("cqsheep_admin_website", "server=192.168.150.130;database={0};userid=root;password=root1234"));
            services.AddSingleton<IAdminUserService, AdminUserService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            ColumnMapper.SetMapper<UserEntity>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
