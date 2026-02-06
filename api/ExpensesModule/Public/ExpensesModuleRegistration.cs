namespace ExpensesModule.Public;

public static class ExpensesModuleRegistration
{
    public static IMvcBuilder AddExpensesControllers(this IMvcBuilder mvcBuilder)
    {
        return mvcBuilder.AddApplicationPart(typeof(ExpensesModuleRegistration).Assembly);
    }

    public static void RegisterExpensesServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IExpenseService, ExpenseService>();
        services.AddSingleton<IBudgetService, BudgetService>();
    }
}