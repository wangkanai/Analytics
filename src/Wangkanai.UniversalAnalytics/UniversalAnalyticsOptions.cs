using System;
using System.Collections.Generic;
using Wangkanai.UniversalAnalytics.Infrastructure;
using Wangkanai.UniversalAnalytics.Utilities;

namespace Wangkanai.UniversalAnalytics
{
    public abstract class UniversalAnalyticsOptions : IUniversalAnalyticsOptions
    {
        private readonly IReadOnlyDictionary<Type, IUniversalAnalyticsOptionsExtensions> _extensions;

        protected UniversalAnalyticsOptions(
            IReadOnlyDictionary<Type, IUniversalAnalyticsOptionsExtensions> extensions)
        {
            Check.NotNull(extensions, nameof(extensions));

            _extensions = extensions;
        }

        public virtual IEnumerable<IUniversalAnalyticsOptionsExtensions> Extensions 
            => _extensions.Values;

        public virtual T FindExtension<T>() 
            where T : class, IUniversalAnalyticsOptionsExtensions
        {
            IUniversalAnalyticsOptionsExtensions extensions;
            return _extensions.TryGetValue(typeof(T), out extensions) ? (T) extensions : null;
        }
    }
}