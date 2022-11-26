using TheChillSpot.Todo.AccountManagement.Application.Account;
using TheChillSpot.Todo.AccountManagement.Application.Account.CreateAccount;

namespace TheChillSpot.Todo.AccountManagement.API.Controllers.v1;

[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{
  private readonly ILogger<AccountsController> _logger;
  private readonly Mediator _mediator;

  public AccountsController(ILogger<AccountsController> logger, Mediator mediator)
  {
    _logger = logger;
    _mediator = mediator;
  }

  [Authorize]
  [HttpPost]
  public async Task<ActionResult> CreateAccount([FromBody] AccountDTO account)
  {
    try
    {
      var newAccount = await _mediator.Send(
        new CreateAccountCommand(
          account.AccountId,
          account.FirstName,
          account.LastName,
          account.Email
        )
      );

      return Ok(newAccount);
    }
    catch
    {
      return StatusCode(500);
    }
  }
}