using System;
using Wangkanai.Analytics;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AnalyticsServiceCollectionExtensions
    {
        public static AnalyticsBuilder AddAnalytics(this IServiceCollection services)
        {
            return new AnalyticsBuilder(services);
        }
    }
}
