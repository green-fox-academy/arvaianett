using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using FoxManager.Entities;
using Microsoft.EntityFrameworkCore;
using FoxManager.Repositories;
using FoxManager.Services;

namespace FoxManager
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<StudentRepository>();
            services.AddScoped<LoginService>();
            services.AddScoped<TaskRepository>();
            services.AddScoped<HomeService>();
            services.AddScoped<TeamRepository>();
            services.AddScoped<TeamService>();
            services.AddScoped<ClassRepository>();
            services.AddScoped<ClassService>();
            services.AddDbContext<FoxContext>(options => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FoxManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseStaticFiles();
        }
    }
}
