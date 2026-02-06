namespace ExpensesModule.Internal.DataAccess.Entities;

internal class BudgetEntity : BaseEntity
{
    public int Amount { get; set; }
    public string CategoryName { get; set; }
    public CategoryEntity Category { get; set; }
}