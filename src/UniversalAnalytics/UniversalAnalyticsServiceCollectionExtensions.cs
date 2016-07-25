using System;
using UniversalAnalytics;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class UniversalAnalyticsServiceCollectionExtensions
    {
        public static IServiceCollection AddUniversalAnalytics(
            this IServiceCollection serviceCollection,
            Action<UniversalAnalyticsOptionBuilder> optionActions)
        {
            return serviceCollection;
        }
    }
}
