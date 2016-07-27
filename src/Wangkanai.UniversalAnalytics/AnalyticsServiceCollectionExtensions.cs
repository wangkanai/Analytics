using System;
using Wangkanai.UniversalAnalytics;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AnalyticsServiceCollectionExtensions
    {
        public static IServiceCollection AddUniversalAnalytics(this IServiceCollection serviceCollection,
            string accountNumber)
        {
            if(serviceCollection == null) throw new ArgumentNullException();
            if(accountNumber == null) throw new ArgumentNullException();

            // waiting to implement features

            return serviceCollection;
        }

        public static IServiceCollection AddUniversalAnalytics(this IServiceCollection serviceCollection,
            Action<AnalyticsOptionsBuilder> optionActions)
        {
            if(serviceCollection == null) throw new ArgumentNullException();
            if(optionActions == null) throw new ArgumentNullException();

            // waiting to implement features

            return serviceCollection;
        }
    }
}
