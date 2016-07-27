using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.UniversalAnalytics.Core.Applications;

namespace Microsoft.Extensions.DependencyInjection
{
    public interface IAnalyticsBuilder
    {
        IServiceCollection Services { get; }
        AnalyticsManager Manager { get; }
    }
}
