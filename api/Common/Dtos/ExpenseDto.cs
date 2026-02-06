namespace Common.Dtos;

public class ExpenseDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string UserName { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
    public string CategoryName { get; set; }
}
