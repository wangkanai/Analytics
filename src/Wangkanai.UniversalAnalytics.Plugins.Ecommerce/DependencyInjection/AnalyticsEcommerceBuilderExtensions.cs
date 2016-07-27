using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.UniversalAnalytics.Core.Builder;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AnalyticsEcommerceBuilderExtensions
    {
        public static IAnalyticsBuilder AddEcommerce(this IAnalyticsBuilder builder)
        {
            return builder;
        }
    }
}
