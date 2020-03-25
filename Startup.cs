using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Westwind.AspNetCore.LiveReload; 

namespace UDEMY
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddMvc(option => option.EnableEndpointRouting = false);
             //MvcOptions.EnableEndpointRouting = false
            // services.AddLiveReload();
             services.AddLiveReload(config =>
             {
                 config.LiveReloadEnabled = true;
            // config.FolderToMonitor = Path.GetFullname(PathString.Combine(Env.ContentRootPath,".."));
             });
             services.AddRazorPages().AddRazorRuntimeCompilation();
             services.AddMvc().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
              app.UseLiveReload();
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();           
          
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routeBuilder =>
            {
                //courses/detail/5
                routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
