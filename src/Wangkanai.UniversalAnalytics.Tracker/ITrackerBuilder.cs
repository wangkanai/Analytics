using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.UniversalAnalytics.Tracker.Abstractions;

namespace Wangkanai.UniversalAnalytics.Tracker
{
    public interface ITrackerBuilder
    {
        IApplicationBuilder ApplicationBuilder { get; }
        ITracker DefaultHandler { get; set; }
        IList<ITracker> Trackers { get; }
        ITrackerBuilder Build();
    }
}
