namespace ExpensesModule.Internal.DataAccess.Entities;

internal class CategoryEntity
{
    public DateTime CreatedAt { get; set; }

    public DateTime ModifiedAt { get; set; }

    public string Name { get; set; }

    public ICollection<ExpenseEntity> Transactions { get; set; } = new List<ExpenseEntity>();

    public ICollection<BudgetEntity> Budgets { get; set; } = new List<BudgetEntity>();
}
