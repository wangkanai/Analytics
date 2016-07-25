using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wangkanai.UniversalAnalytics.Infrastructure
{
    public interface IUniversalAnalyticsOptionsBuilderInfrastructure
    {
        void AddOrUpdateExtension<T>(T extension) where T : class, IUniversalAnalyticsOptionsExtension;
    }
}
