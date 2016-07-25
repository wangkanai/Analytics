using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.UniversalAnalytics.Infrastructure
{
    public interface IUniversalAnalyticsOptionsExtensions
    {
        void ApplyServices(IServiceCollection services);
    }
}