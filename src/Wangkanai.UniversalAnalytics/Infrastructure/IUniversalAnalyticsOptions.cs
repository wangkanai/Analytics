using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wangkanai.UniversalAnalytics.Infrastructure
{
    public interface IUniversalAnalyticsOptions
    {
        IEnumerable<IUniversalAnalyticsOptionsExtensions> Extensions { get; }
        T FindExtension<T>() where T : class, IUniversalAnalyticsOptionsExtensions;
    }
}
