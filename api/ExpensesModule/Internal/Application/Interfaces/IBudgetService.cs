namespace ExpensesModule.Internal.Application.Interfaces;

internal interface IBudgetService
{
    Task<List<BudgetDto>> GetBudgets(CancellationToken cancellationToken);

    Task CreateOrUpdateBudget(BudgetDto request, CancellationToken cancellationToken);

    Task DeleteBudget(string categoryName, CancellationToken cancellationToken);
}
