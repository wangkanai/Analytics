using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.UniversalAnalytics.Infrastructure;
using Wangkanai.UniversalAnalytics.Utilities;

namespace Wangkanai.UniversalAnalytics
{
    public class UniversalAnalyticsOptionsBuilder : IUniversalAnalyticsOptionsBuilderInfrastructure
    {

        private UniversalAnalyticsOptions _options;
        public UniversalAnalyticsOptionsBuilder()
            : this(new UniversalAnalyticsOptions())
        {
            
        }

        public UniversalAnalyticsOptionsBuilder(UniversalAnalyticsOptions options)
        {
            Check.NotNull(options, nameof(options));

            _options = options;
        }

        public UniversalAnalyticsOptions Options => _options;

        void IUniversalAnalyticsOptionsBuilderInfrastructure.AddOrUpdateExtension<T>(T extension)
        {
            Check.NotNull(extension, nameof(extension));
            _options = _options.WithExtension(extension);
        }
    }
}
