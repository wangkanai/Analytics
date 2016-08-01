using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.UniversalAnalytics.Tracker;

namespace Wangkanai.UniversalAnalytics.Core.Builder
{
    /// <summary>
    /// Extension methods for <see cref="IApplicationBuilder"/> to add Universal Analytics to the request execution pipeline.
    /// </summary>
    public static class AnalyticsBuilderExtensions
    {

        public static IApplicationBuilder UseUniversalAnalytics(this IApplicationBuilder app,
            string TrackerId)
        {
            return app.UseUniversalAnalytics(trackers =>
            {
                
            });
        }

        public static IApplicationBuilder UseUniversalAnalytics(this IApplicationBuilder app,
            Action<ITrackerBuilder> trackers)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));
            if (trackers == null) throw new ArgumentNullException(nameof(trackers));

            return app;
        }
    }
}
