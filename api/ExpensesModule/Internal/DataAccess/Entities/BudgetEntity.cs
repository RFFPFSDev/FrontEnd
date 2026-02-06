namespace ExpensesModule.Internal.DataAccess.Entities;

internal class BudgetEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public int Amount { get; set; }
    public string CategoryName { get; set; }
    public CategoryEntity Category { get; set; }
}