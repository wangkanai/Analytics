using System;
using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.Analytics
{
    public class AnalyticsBuilder
    {
        public AnalyticsBuilder(IServiceCollection services)
        {
            
        }

        public virtual AnalyticsBuilder AddDisplayFeatures()
        {
            return this;
        }
        public virtual AnalyticsBuilder AddEcommerce()
        {
            return this;
        }
    }
}
