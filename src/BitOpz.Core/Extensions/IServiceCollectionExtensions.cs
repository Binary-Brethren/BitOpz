using BitOpz.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BitOpz.Core.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureBitWizerServices(this IServiceCollection services)
        {
            return services
                .AddTransient<IBitWizer, BitWizer>();
        }
    }
}
