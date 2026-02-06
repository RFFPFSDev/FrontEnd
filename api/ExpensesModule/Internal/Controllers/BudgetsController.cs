namespace ExpenseModule.Internal.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
internal class BudgetsController(IBudgetService budgetService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetBudget(CancellationToken cancellationToken)
    {
        return Ok(await budgetService.GetBudgets(cancellationToken));
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrUpdateBudget([FromBody] BudgetDto request, CancellationToken cancellationToken)
    {
        await budgetService.CreateOrUpdateBudget(request, cancellationToken);
        return Ok();
    }

    [HttpDelete("{categoryName}")]
    public async Task<IActionResult> DeleteBudget(string categoryName, CancellationToken cancellationToken)
    {
        await budgetService.DeleteBudget(categoryName, cancellationToken);
        return Ok($"Budget {categoryName} deleted");
    }
}
