using System.Text.Json.Serialization;

namespace TheChillSpot.Todo.AccountManagement.Application.Account;

public class AccountDTO
{
    [JsonPropertyName("accountId")]
    public Guid AccountId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}