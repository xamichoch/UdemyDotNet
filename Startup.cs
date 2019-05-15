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
                    .AddMvcOptions(option => {
                        option.EnableEndpointRouting = false;
                    });
        }

        // Qui dentro configuriamo, aggiungendo dei middleware, la pipeline di esecuzione delle richieste alla nostra applicazione
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsProduction())
            {
                app.UseHttpsRedirection();
            }
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(configureRoutes => {
                configureRoutes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });          
            
        }
    }
}
