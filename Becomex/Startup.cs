using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Modelo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Modelo.Domain.Interfaces.Services;
using Modelo.Service;
using Modelo.Domain.Interfaces.Repositories;
using Modelo.Infra.Data.Repository;


namespace MakeMagic
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
           // services.AddDbContext<context>(options => options.UseSqlServer(Configuration.GetConnectionString("DB")));
            services.AddControllers();
            services.AddScoped<context>();
            services.AddTransient<IRoboRepository, RoboRepository>();
            services.AddTransient<IRoboService, RoboService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
