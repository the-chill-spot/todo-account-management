using System.Text.Json.Serialization;

namespace TheChillSpot.Todo.AccountManagement.Application.Account;

public class AccountDTO
{
    [JsonPropertyName("accountId")]
    public Guid AccountId { get; set; }

    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public string LastName { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }
}