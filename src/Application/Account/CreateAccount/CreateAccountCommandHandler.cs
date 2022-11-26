namespace TheChillSpot.Todo.AccountManagement.Application.Account.CreateAccount;

public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, AccountDTO>
{
    private readonly ILogger<CreateAccountCommandHandler> _logger;

    public CreateAccountCommandHandler(ILogger<CreateAccountCommandHandler> logger)
    {
        _logger = logger;
    }

    public Task<AccountDTO> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
