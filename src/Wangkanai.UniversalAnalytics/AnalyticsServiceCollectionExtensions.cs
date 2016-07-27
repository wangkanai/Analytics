using System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension method for setting up Universal in an <see cref="IServiceCollection" />
    /// </summary>
    public static class AnalyticsServiceCollectionExtensions
    {
        public static IServiceCollection AddUniversalAnalytics(
            this IServiceCollection serviceCollection,
            string accountNumber)
            => AddUniversalAnalytics(serviceCollection, accountNumber, null);


        public static IServiceCollection AddUniversalAnalytics(
            this IServiceCollection serviceCollection,
            string accountNumber,
            Action<AnalyticsOptionsBuilder> optionActions)
        {
            if (serviceCollection == null) throw new ArgumentNullException(nameof(serviceCollection));
            if (accountNumber == null) throw new ArgumentNullException(nameof(accountNumber));

            serviceCollection.AddSingleton<AnalyticsOptions>();

            return serviceCollection;
        }
    }
}
