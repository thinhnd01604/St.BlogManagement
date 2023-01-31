using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace St.BlogManagement
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<BlogManagementHttpApiHostModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
