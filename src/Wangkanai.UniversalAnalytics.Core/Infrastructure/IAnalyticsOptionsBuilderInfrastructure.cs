using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wangkanai.UniversalAnalytics.Infrastructure
{
    public interface IAnalyticsOptionsBuilderInfrastructure
    {
        void AddOrUpdateExtension<T>(T extension) where T : class, IAnalyticsOptionsExtension;
    }
}
