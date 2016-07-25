using System;
using System.Collections.Generic;
using System.Linq;
using Wangkanai.UniversalAnalytics.Infrastructure;
using Wangkanai.UniversalAnalytics.Utilities;

namespace Wangkanai.UniversalAnalytics
{
    public class UniversalAnalyticsOptions : IUniversalAnalyticsOptions
    {
        private readonly IReadOnlyDictionary<Type, IUniversalAnalyticsOptionsExtension> _extensions;

        public UniversalAnalyticsOptions() :
            this(new Dictionary<Type, IUniversalAnalyticsOptionsExtension>())
        {
        }

        public UniversalAnalyticsOptions(
            IReadOnlyDictionary<Type, IUniversalAnalyticsOptionsExtension> extensions)
        {
            Check.NotNull(extensions, nameof(extensions));

            _extensions = extensions;
        }


        public IEnumerable<IUniversalAnalyticsOptionsExtension> Extensions => _extensions.Values;

        public T FindExtension<T>()
            where T : class, IUniversalAnalyticsOptionsExtension
        {
            IUniversalAnalyticsOptionsExtension extension;
            return _extensions.TryGetValue(typeof(T), out extension) ? (T)extension : null;
        }

        public UniversalAnalyticsOptions WithExtension<T>(T extension) 
            where T : class, IUniversalAnalyticsOptionsExtension
        {
            Check.NotNull(extension, nameof(extension));

            var extensions = Extensions.ToDictionary(p => p.GetType(), p => p);
            extensions[typeof(T)] = extension;

            return new UniversalAnalyticsOptions(extensions);
        }
    }
}