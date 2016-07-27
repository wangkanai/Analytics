using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.UniversalAnalytics.Core.Applications;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AnalyticsCoreServiceCollectionExtensions
    {
        public static AnalyticsManager GetAnalyticsManager(IServiceCollection services)
        {
            var manager = new AnalyticsManager();
            return manager;
        }
    }
}
