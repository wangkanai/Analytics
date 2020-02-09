// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.Analytics.Tracker.Abstractions;

namespace Wangkanai.Analytics.Tracker
{
    public interface ITrackerBuilder
    {
        IApplicationBuilder ApplicationBuilder { get; }
        ITracker DefaultHandler { get; set; }
        IList<ITracker> Trackers { get; }
        ITrackerBuilder Build();
    }
}
