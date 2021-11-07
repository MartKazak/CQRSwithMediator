using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DemoApp.DataAccess.EF
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterEntityFrameworkHandlers(this IServiceCollection services) => 
            services.AddMediatR(typeof(Dependencies).Assembly);
    }
}
