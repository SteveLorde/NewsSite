using NewsWebsiteServerApp.Data;
using NewsWebsiteServerApp.Services.NewsRepo;

namespace NewsWebsiteServerApp.Services;

public static class ServicesRegister
{
    public static void AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<DataContext>();
        serviceCollection.AddScoped<INewsRepo>();
    }
}