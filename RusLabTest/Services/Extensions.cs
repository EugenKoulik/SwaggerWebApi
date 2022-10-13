using RusLabTest.Interfaces;

namespace RusLabTest.Services
{
    public static class Extensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();
        }
    }
}

