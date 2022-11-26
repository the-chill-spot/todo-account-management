namespace TheChillSpot.Todo.AccountManagement.Application.Account.CreateAccount;

public class CreateAccountCommand : IRequest<AccountDTO>
{
    public Guid AccountId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public CreateAccountCommand(Guid accountId, string firstName, string lastName, string email)
    {
        AccountId = accountId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}
