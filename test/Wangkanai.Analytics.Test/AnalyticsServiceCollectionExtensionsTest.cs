// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Moq;
using System.Reflection;

namespace Wangkanai.Analytics.Test
{
    public class AnalyticsServiceCollectionExtensionsTest
    {
        [Fact]
        public void RegistrationServiceTypes()
        {
            var services = new ServiceCollection();
            services.AddAnalytics();
        }

        private IHostingEnvironment GetHostingEnvironment()
        {
            var environment = new Mock<IHostingEnvironment>();
            environment
                .Setup(e => e.ApplicationName)
                .Returns(typeof(AnalyticsServiceCollectionExtensionsTest).GetTypeInfo().Assembly.GetName().Name);

            return environment.Object;
        }
    }
}
