namespace BudgetModule.Internal.DataAccess.Entities;

internal class BaseEntity
{
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime ModifiedAt { get; set; }
}
