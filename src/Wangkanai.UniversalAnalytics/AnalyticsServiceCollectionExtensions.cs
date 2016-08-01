// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using System;
using Wangkanai.UniversalAnalytics;
using Wangkanai.UniversalAnalytics.Core.Applications;
using Wangkanai.UniversalAnalytics.Core.Builder;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension method for setting up Universal in an <see cref="IServiceCollection" />
    /// </summary>
    public static class AnalyticsServiceCollectionExtensions
    {
        /// <summary>
        ///     Registers the Universal Analytics as a services in the <see cref="IServiceCollection" />.
        ///     You use this method when using dependency injection in your application, such as with ASP.NET.
        /// </summary>
        /// <example>
        ///    <code> 
        ///        public void ConfigureServices(IServiceCollection services)
        ///        {                            
        ///            services.AddMvc();
        /// 
        ///            services.AddUniversalAnalytics();
        ///        }
        ///    </code>
        /// </example>
        /// <param name="services">The <see cref="IServiceCollection" /> to add services to. </param>        
        /// <returns>An <see cref="IAnalyticsBuilder"/> that can be used to further configure the MVC services.</returns>
        public static IAnalyticsBuilder AddUniversalAnalytics(
                this IServiceCollection services)
                => AddUniversalAnalytics(services, null);


        public static IAnalyticsBuilder AddUniversalAnalytics(
            this IServiceCollection services,            
            Action<AnalyticsOptionsBuilder> options)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));            

            var manager = new AnalyticsManager();// GetAnalyticsManager(services);

            return new AnalyticsBuilder(services, manager);
        }
    }
}
