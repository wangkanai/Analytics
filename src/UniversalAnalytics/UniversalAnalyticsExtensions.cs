// Copyright (c) Sarin Na Wangkanai. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using UniversalAnalytics;

namespace Microsoft.AspNetCore.Builder
{
    public static class UniversalAnalyticsExtensions
    {
        public static IApplicationBuilder UseUniversalAnalytics(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UniversalAnalyticsMiddleware>();
        }
    }
}
