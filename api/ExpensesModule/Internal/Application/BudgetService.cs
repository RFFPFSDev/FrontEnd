namespace ExpensesModule.Internal.Application;

internal class BudgetService : IBudgetService
{
    private List<BudgetDto> Budgets = new List<BudgetDto>();

    public async Task<List<BudgetDto>> GetBudgets(CancellationToken cancellationToken)
    {
        return Budgets;
    }

    public async Task CreateOrUpdateBudget(BudgetDto request, CancellationToken cancellationToken)
    {
        var budgetIndex = Budgets.FindIndex(e => e.CategoryName == request.CategoryName);

        if (budgetIndex >= 0)
        {
            Budgets[budgetIndex] = request;
            return;
        }

        Budgets.Add(request);
    }

    public async Task DeleteBudget(string categoryName, CancellationToken cancellationToken)
    {
        var budget = Budgets.FirstOrDefault(e => e.CategoryName == categoryName);

        if (budget == null)
        {
            throw new Exception($"Budget {categoryName} doesn't exist");
        }

        Budgets.Remove(budget);
        return;
    }
}
