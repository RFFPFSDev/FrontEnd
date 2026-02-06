namespace personal_finance_manager;

internal static class ModulesRegistration
{
    public static async Task ApplyMigrationsAsync(
        this IHost app)
    {
    }

    public static void ConfigureApi(this IServiceCollection services)
    {
        services
            .AddExceptionHandler<GlobalExceptionHandler>()
            .AddProblemDetails();
    }

    public static IMvcBuilder AddApplicationParts(this IMvcBuilder mvcBuilder)
    {
        return mvcBuilder
            .AddExpensesControllers();
    }

    public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.RegisterExpensesServices(configuration);
    }
}
