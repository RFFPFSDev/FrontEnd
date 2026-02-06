namespace ExpensesModule.Internal.DataAccess.Entities;

internal class TransactionEntity : BaseEntity
{
    public Guid UserId { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
    public string CategoryName { get; set; }
    public CategoryEntity Category { get; set; }
}
