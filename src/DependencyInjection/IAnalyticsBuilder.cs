﻿// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.Analytics.Core.Applications;

namespace Microsoft.Extensions.DependencyInjection
{
    public interface IAnalyticsBuilder
    {
        IServiceCollection Services { get; }
        AnalyticsManager Manager { get; }
    }
}
