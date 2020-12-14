using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MKTFY.App;
using MKTFY.Models.Entities;

namespace MKTFY.Auth
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
            services.AddDbContext<ApplicationDbContext>(builder =>
                builder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
                    b=>
                    {
                        b.MigrationsAssembly("MKTFY.app");
                    }));

            services.AddIdentity<AppUser, IdentityRole> ()
                 .AddEntityFrameworkStores<ApplicationDbContext>(); // Tell Identity which EF DbContext to use
            var builder = services.AddIdentityServer(option =>
            {
                option.IssuerUri = Configuration.GetSection("Identity").GetValue<string>("Authority");
            })
                .AddOperationalStore(options =>
               {
                   options.ConfigureDbContext = builder => builder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
                       npgSqlOptions =>
                       {
                           npgSqlOptions.MigrationsAssembly("MKTFY.App");
                       });
               })
                .AddDeveloperSigningCredential()
                .AddInMemoryApiResources(Config.ApiResources)
                .AddInMemoryApiScopes(Config.ApiScopes)
                .AddInMemoryClients(Config.Clients)
                .AddAspNetIdentity<AppUser>();
                //.AddTestUsers(Config.Users);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseIdentityServer();

            // app.UseHttpsRedirection();

            // app.UseRouting();

            // app.UseAuthorization();

            // app.UseEndpoints(endpoints =>
            // {
            //     endpoints.MapControllers();
            // });
        }
    }
}
