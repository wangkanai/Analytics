using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.UniversalAnalytics.Infrastructure
{
    public interface IUniversalAnalyticsOptionsExtension
    {
        void ApplyServices(IServiceCollection services);
    }
}