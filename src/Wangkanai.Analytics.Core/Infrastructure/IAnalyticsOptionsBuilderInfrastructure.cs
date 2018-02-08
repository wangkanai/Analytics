// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wangkanai.Analytics.Infrastructure
{
    public interface IAnalyticsOptionsBuilderInfrastructure
    {
        void AddOrUpdateExtension<T>(T extension) where T : class, IAnalyticsOptionsExtension;
    }
}
