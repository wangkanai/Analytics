using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Moq;
using System.Reflection;

namespace Wangkanai.UniversalAnalytics.Test
{
    public class AnalyticsServiceCollectionExtensionsTest
    {
        [Fact]
        public void RegistrationServiceTypes()
        {
            var services = new ServiceCollection();
            services.AddUniversalAnalytics();
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
