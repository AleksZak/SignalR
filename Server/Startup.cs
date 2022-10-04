using Microsoft.AspNetCore.SignalR;
using Server.HUB;
using Server.Worker;

namespace Server
{

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();

            services.AddSingleton<IUserIdProvider, MyUserProvider>();

            services.AddHostedService<NoticeWorker>();

            services.AddCors();
        }
      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(policy =>
            {
                policy
                    .SetIsOriginAllowed(origin => true)
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<MessageHub>("/messages");
            });
        }
    }
}



