namespace ExpensesModule.Internal.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
internal class ExpensesController(IExpenseService expenseService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetExpenses(CancellationToken cancellationToken)
    {
        return Ok(await expenseService.GetExpenses(cancellationToken));
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrUpdateExpense([FromBody] ExpenseDto request, CancellationToken cancellationToken)
    {
        if (request.Id == Guid.Empty)
        {
            await expenseService.CreateExpense(request, cancellationToken);
            return Ok();
        }

        await expenseService.UpdateExpense(request, cancellationToken);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteExpense(Guid id, CancellationToken cancellationToken)
    {
        await expenseService.DeleteExpense(id, cancellationToken);
        return Ok($"Expense {id} deleted");
    }
}