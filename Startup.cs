using System;
using System.IO;
using CorsoDotnet.Models.Services.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CorsoDotnet
{
    public class Startup
    {
        // Qui dentro aggiungiamo i servizi che vogliamo usare nel metodo Configure
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                     .AddMvcOptions(option =>
                     {
                         option.EnableEndpointRouting = false;
                     });

            //In questo modo mettiamo il moto il meccanismo della dependency injection, 
            // creando una istanza di una classe CourseService che implementa l'interfaccia ICourseService

            services.AddTransient<ICourseService, CourseService>();

        }


        // Qui dentro configuriamo, aggiungendo dei middleware, la pipeline di esecuzione delle richieste alla nostra applicazione
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime lifetime)
        {
            if (env.IsDevelopment())
            {
                lifetime.ApplicationStarted.Register(() =>
                {
                    string filePath = Path.Combine(env.ContentRootPath, "bin/reload.txt");
                    File.WriteAllText(filePath, DateTime.Now.ToString());
                });

                app.UseDeveloperExceptionPage();
            }

            if (env.IsProduction())
            {
                app.UseHttpsRedirection();
            }

            app.UseStaticFiles();

            app.UseMvc(configureRoutes =>
            {
                configureRoutes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
