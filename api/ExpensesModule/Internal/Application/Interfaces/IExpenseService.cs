namespace ExpensesModule.Internal.Application.Interfaces;

internal interface IExpenseService
{
    Task<List<ExpenseDto>> GetExpenses(CancellationToken cancellationToken);

    Task CreateExpense(ExpenseDto request, CancellationToken cancellationToken);

    Task UpdateExpense(ExpenseDto request, CancellationToken cancellationToken);

    Task DeleteExpense(Guid id, CancellationToken cancellationToken);
}
