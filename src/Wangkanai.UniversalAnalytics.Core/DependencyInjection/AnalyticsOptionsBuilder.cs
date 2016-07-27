using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.UniversalAnalytics.Infrastructure;

namespace Wangkanai.UniversalAnalytics
{
    public class AnalyticsOptionsBuilder : IAnalyticsOptionsBuilderInfrastructure
    {

        private AnalyticsOptions _options;
        public AnalyticsOptionsBuilder()
            : this(new AnalyticsOptions())
        {
            
        }

        public AnalyticsOptionsBuilder(AnalyticsOptions options)
        {
            if(options == null) throw new ArgumentNullException();            

            _options = options;
        }

        public AnalyticsOptions Options => _options;

        void IAnalyticsOptionsBuilderInfrastructure.AddOrUpdateExtension<T>(T extension)
        {
            if(extension == null) throw new ArgumentNullException();
            
            _options = _options.WithExtension(extension);
        }
    }
}
