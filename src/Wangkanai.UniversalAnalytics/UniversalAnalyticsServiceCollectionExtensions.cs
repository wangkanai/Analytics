using System;
using Wangkanai.UniversalAnalytics;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class UniversalAnalyticsServiceCollectionExtensions
    {
        public static IServiceCollection AddUniversalAnalytics(
            this IServiceCollection serviceCollection,
            Action<UniversalAnalyticsOptionsBuilder> optionActions)
        {
            return serviceCollection;
        }
    }
}
