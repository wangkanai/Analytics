using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.UniversalAnalytics.Infrastructure
{
    public interface IAnalyticsOptionsExtension
    {
        void ApplyServices(IServiceCollection services);
    }
}