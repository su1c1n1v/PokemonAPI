using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PokemonAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace PokemonAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PokemonContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("PokemonConnection")));

            //Setup the newtonsoftJson
            services.AddControllers().AddNewtonsoftJson(Temp => {
                Temp.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            } );

            //Mock demonstration
            //services.AddScoped<IPokemonRepo, MockPokemonRepo>();
            //SQL
            services.AddScoped<IPokemonRepo, SqlPokemonRepo>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
