using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
=======
using System.Net.Http;
>>>>>>> a361a80340aac6186c0d0c8cadcd7edaed324aba
using System.Threading.Tasks;

namespace Shopping.Client
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
<<<<<<< HEAD
            services.AddRazorPages();
=======
            services.AddHttpClient("ShoppingAPIClient", client =>
            {
                //client.BaseAddress = new Uri("http://localhost:5000/"); // Shopping.API url
                client.BaseAddress = new Uri(Configuration["ShoppingAPIUrl"]);
            });
            services.AddControllersWithViews();
        }

        private void ShoppingAPIClient(IServiceProvider arg1, HttpClient arg2)
        {
            throw new NotImplementedException();
>>>>>>> a361a80340aac6186c0d0c8cadcd7edaed324aba
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
<<<<<<< HEAD
                app.UseExceptionHandler("/Error");
            }

=======
                app.UseExceptionHandler("/Home/Error");
            }
>>>>>>> a361a80340aac6186c0d0c8cadcd7edaed324aba
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
<<<<<<< HEAD
                endpoints.MapRazorPages();
=======
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
>>>>>>> a361a80340aac6186c0d0c8cadcd7edaed324aba
            });
        }
    }
}
