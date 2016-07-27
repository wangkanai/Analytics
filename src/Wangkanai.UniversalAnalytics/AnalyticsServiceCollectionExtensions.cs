// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension method for setting up Universal in an <see cref="IServiceCollection" />
    /// </summary>
    public static class AnalyticsServiceCollectionExtensions
    {
        /// <summary>
        ///     Registers the Universal Analytics as a service in the <see cref="IServiceCollection" />.
        ///     You use this method when using dependency injection in your application, such as with ASP.NET.
        /// </summary>
        /// <example>
        ///    <code> 
        ///        public void ConfigureServices(IServiceCollection services)
        ///        {            
        ///            services.AddUniversalAnalytics("UA-XXXX-Y");
        ///         
        ///            services.AddMvc();
        ///        }
        ///    </code>
        /// </example>
        /// <param name="service">The <see cref="IServiceCollection" /> to add services to. </param>
        /// <param name="trackerId">The tracking ID / web property ID. The format is UA-XXXX-Y. All collected data is associated by this ID.</param>
        /// <returns></returns>
        public static IServiceCollection AddUniversalAnalytics(
                this IServiceCollection service,
                string trackerId)
                => AddUniversalAnalytics(service, trackerId, null);


        public static IServiceCollection AddUniversalAnalytics(
            this IServiceCollection service,
            string trackerId,
            Action<AnalyticsOptionsBuilder> options)
        {
            if (service == null) throw new ArgumentNullException(nameof(service));
            if (trackerId == null) throw new ArgumentNullException(nameof(trackerId));

            service.AddSingleton<AnalyticsOptions>();

            return service;
        }
    }
}
