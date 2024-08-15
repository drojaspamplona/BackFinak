using BackFinak.Services;
using BackFinak.Services.ServicesInterface;

namespace BackFinak.Extensions;

public static class ServiceRegistrationExtensions
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddScoped<IEventLogService, EventLogService>();
    }
}