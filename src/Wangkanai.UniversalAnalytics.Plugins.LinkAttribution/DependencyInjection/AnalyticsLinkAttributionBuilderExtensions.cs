using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AnalyticsLinkAttributionBuilderExtensions
    {
        public static IAnalyticsBuilder AddLinkAttribution(this IAnalyticsBuilder builder)
        {
            return builder;
        }
    }
}
