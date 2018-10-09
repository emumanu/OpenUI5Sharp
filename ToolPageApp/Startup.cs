using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace ToolPageApp
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
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles(new StaticFileOptions() {

            });
            app.UseCookiePolicy();

            // Add new content types
            var provider = new FileExtensionContentTypeProvider();
            provider.Mappings[".properties"] = System.Net.Mime.MediaTypeNames.Text.Plain;

            if (env.IsDevelopment()) {
                app.UseStaticFiles(new StaticFileOptions() {
                    ContentTypeProvider = provider,

                    // do not cache anything when we are developing
                    OnPrepareResponse = context => {
                        context.Context.Response.Headers[HeaderNames.CacheControl] = "private, no-store";
                        context.Context.Response.Headers[HeaderNames.Pragma] = "no-cache";
                        context.Context.Response.Headers[HeaderNames.Expires] = "-1";
                    },
                });
            } else {
                app.UseStaticFiles(new StaticFileOptions() {
                    ContentTypeProvider = provider,
                });
            }

            app.UseMvc();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}"
                );
                routes.MapRoute(
                    name: "UI5StaticViewsWithoutFolder",
                    template: "ui5/view/{viewFolder}/{viewName}.xml",
                    defaults: new { controller = "UI5Views", action = "GetStaticView" }
                );
                routes.MapRoute(
                    name: "UI5StaticViewsWithFolder",
                    template: "ui5/view/{viewName}.xml",
                    defaults: new { controller = "UI5Views", action = "GetStaticView", viewFolder = default(string) }
                );

                // TODO: add routes for dynamic xml views
            });
        }
    }
}
