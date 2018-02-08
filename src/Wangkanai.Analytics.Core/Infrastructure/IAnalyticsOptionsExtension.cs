// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.Analytics.Infrastructure
{
    public interface IAnalyticsOptionsExtension
    {
        void ApplyServices(IServiceCollection services);
    }
}