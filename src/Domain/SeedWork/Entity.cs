namespace TheChillSpot.Todo.AccountManagement.Domain.SeedWork;

public abstract class Entity<TId>
{
    private List<INotification> _domainEvents;
    public TId Id { get; protected set; }
}
