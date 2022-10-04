using AutoMapper;
using SignalR_App.Hubs;
using Messanger.DataAccess;

namespace SignalR_App
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public static IMapper Mapper { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
            services.AddControllers();
            services.AddDbContext<MessangerContext>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(policy => 
            policy.SetIsOriginAllowed(origin => true)
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials());

            app.UseRouting();          
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<NotificationHub>("/messages");
            });
        }
    }
}
