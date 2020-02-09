// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Wangkanai.Analytics.Infrastructure;

namespace Microsoft.Extensions.DependencyInjection
{
    public class AnalyticsOptions : IAnalyticsOptions
    {
        private readonly IReadOnlyDictionary<Type, IAnalyticsOptionsExtension> _extensions;

        public AnalyticsOptions() :
            this(new Dictionary<Type, IAnalyticsOptionsExtension>())
        {
        }

        public AnalyticsOptions(
            IReadOnlyDictionary<Type, IAnalyticsOptionsExtension> extensions)
        {
            if (extensions == null) throw new ArgumentNullException();

            _extensions = extensions;
        }


        public IEnumerable<IAnalyticsOptionsExtension> Extensions => _extensions.Values;

        public T FindExtension<T>()
            where T : class, IAnalyticsOptionsExtension
        {
            IAnalyticsOptionsExtension extension;
            return _extensions.TryGetValue(typeof(T), out extension) ? (T)extension : null;
        }

        public AnalyticsOptions WithExtension<T>(T extension)
            where T : class, IAnalyticsOptionsExtension
        {
            if (extension == null) throw new ArgumentNullException();

            var extensions = Extensions.ToDictionary(p => p.GetType(), p => p);
            extensions[typeof(T)] = extension;

            return new AnalyticsOptions(extensions);
        }
    }
}