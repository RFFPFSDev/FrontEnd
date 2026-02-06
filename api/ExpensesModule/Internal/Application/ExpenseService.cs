namespace ExpensesModule.Internal.Application;

internal class ExpenseService : IExpenseService
{
    private List<ExpenseDto> Expenses = new List<ExpenseDto>();

    public async Task<List<ExpenseDto>> GetExpenses(CancellationToken cancellationToken)
    {
        return Expenses;
    }

    public async Task CreateExpense(ExpenseDto request, CancellationToken cancellationToken)
    {
        request.Id = Guid.NewGuid();
        Expenses.Add(request);
    }

    public async Task UpdateExpense(ExpenseDto request, CancellationToken cancellationToken)
    {
        var expenseIndex = Expenses.FindIndex(e => e.Id == request.Id);

        if (expenseIndex < 0)
        {
            throw new Exception($"Expense {request.Id} doesn't exist");
        }

        Expenses[expenseIndex] = request;
    }

    public async Task DeleteExpense(Guid id, CancellationToken cancellationToken)
    {
        var expense = Expenses.FirstOrDefault(e => e.Id == id);

        if (expense == null)
        {
            throw new Exception($"Expense {id} doesn't exist");
        }

        Expenses.Remove(expense);
        return;
    }
}
