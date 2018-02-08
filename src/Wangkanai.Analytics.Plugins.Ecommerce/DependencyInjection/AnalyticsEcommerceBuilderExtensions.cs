// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.Analytics.Core.Builder;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AnalyticsEcommerceBuilderExtensions
    {
        public static IAnalyticsBuilder AddEcommerce(this IAnalyticsBuilder builder)
        {
            return builder;
        }
    }
}
