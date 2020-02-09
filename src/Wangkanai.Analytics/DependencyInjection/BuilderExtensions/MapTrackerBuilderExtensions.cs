// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.Analytics.Tracker;

namespace Microsoft.AspNetCore.Builder
{
    public static class MapTrackerBuilderExtensions
    {
        public static ITrackerBuilder AddTracker(this ITrackerBuilder builder, string trackerId)
        {
            return AddTracker(builder, trackerId, null);
        }

        public static ITrackerBuilder AddTracker(this ITrackerBuilder builder, string trackerId, object options)
        {
            if (builder.DefaultHandler == null) throw new InvalidOperationException("Default Handler must be set");
            
            // waiting for implementation

            return builder;
        }
    }
}
