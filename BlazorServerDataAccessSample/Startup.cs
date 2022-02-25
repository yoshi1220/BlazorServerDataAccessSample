using BlazorServerDataAccessSample.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using BlazorServerDataAccessSample.Repositories;
using BlazorServerDataAccessSample.Services;

namespace BlazorServerDataAccessSample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            AppSettings.Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            //DB関連
            services.AddDbContext<SampleDbContext>(options =>
            {
                options.UseSqlServer(AppSettings.Configuration.GetConnectionString("DefaultConnection"));
            });

            //Repository関連
            //services.AddScoped<IUserRepository, UserRepository>(); //EntityFrameworkCoreを使う場合
            services.AddScoped<IUserRepository, UserRepositoryDapper>(); //Dapperを使う場合

            //Service関連            
            services.AddScoped<IUserService, UserService>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }

    //appsettings.jsonからデータを取得する際に使用。どこからでも参照可能にする
    public static class AppSettings
    {
        public static IConfiguration Configuration { get; set; }
    }
}
