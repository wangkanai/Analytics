using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wangkanai.UniversalAnalytics
{
    public class UniversalAnalyticsMiddleware
    {
        private readonly RequestDelegate _next;

        public UniversalAnalyticsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next(context);
        }
    }
}
