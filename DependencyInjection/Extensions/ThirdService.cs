using Supabase;

namespace cycle_store_be.DependencyInjection.Extensions
{
    public static class ThirdService
    {
        public static IServiceCollection ThirdServiceDI(this IServiceCollection services, IConfiguration configuration) 
        {
            var url = Environment.GetEnvironmentVariable("SUPABASE_URL") ?? configuration["SupabaseSettings:BaseUrl"]!;
            var key = Environment.GetEnvironmentVariable("SUPABASE_KEY") ?? configuration["SupabaseSettings:ApiKey"]!;

            var options = new SupabaseOptions
            {
                AutoRefreshToken = true,
                AutoConnectRealtime = true,
            };
            services.AddSingleton(provider => new Client(url, key, options));

            return services;
        }
    }
}
