// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.Analytics.Tracker;

namespace Wangkanai.Analytics.Core.Builder
{
    /// <summary>
    /// Extension methods for <see cref="IApplicationBuilder"/> to add Universal Analytics to the request execution pipeline.
    /// </summary>
    public static class AnalyticsBuilderExtensions
    {

        public static IApplicationBuilder UseAnalytics(this IApplicationBuilder app,
            string TrackerId)
        {
            return app.UseAnalytics(trackers =>
            {
                
            });
        }

        public static IApplicationBuilder UseAnalytics(this IApplicationBuilder app,
            Action<ITrackerBuilder> trackers)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));
            if (trackers == null) throw new ArgumentNullException(nameof(trackers));

            return app;
        }
    }
}
