using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using projek.api.Interfaces;
using projek.api.Persistence;
using projek.api.Repository;

namespace Projek.API
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
            services.AddSwaggerGen(c => 
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Projek API" , Version = "v1"})
            );

            // var connection = Configuration.GetConnectionString("ProjekTest"); 
            // services.AddDbContext<ProjekDbContext>(options =>
            //     options.UseSqlServer(connection)
            // );

            services.AddScoped<IUsuario, UsuarioRepository>();
            
            services.AddDbContext<ProjekDbContext>(options =>
                options.UseInMemoryDatabase("Db_database")
            );

            
            services.AddControllers().AddNewtonsoftJson( 
                options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddCors(options => options.AddPolicy("CorsPolicy" , 
                builder => builder
                    .WithOrigins("http://localhost:4200") 
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials() ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI( c => 
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Projek API")
            );

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("CorsPolicy");


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
