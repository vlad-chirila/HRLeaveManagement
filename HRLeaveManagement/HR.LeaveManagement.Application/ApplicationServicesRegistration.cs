namespace HR.LeaveManagement.Application
{
    using Microsoft.Extensions.DependencyInjection;
    using System.Reflection;

    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); /* typeof(MappingProfile) */
        }
    }
}
