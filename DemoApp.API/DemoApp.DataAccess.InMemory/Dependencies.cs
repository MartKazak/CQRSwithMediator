using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DemoApp.DataAccess.InMemory
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterInMemoryHandlers(this IServiceCollection services)
        {
            return services.AddMediatR(typeof(Dependencies).Assembly);
        }
    }
}
