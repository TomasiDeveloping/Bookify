namespace Bookify.Domain.Abstractions;

public abstract class Entity(Guid id)
{
    private readonly List<IDomainEvent> _domainEvents = [];
    public Guid Id { get; init; } = id;

    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }

    public void ClearDomainEvent()
    {
        _domainEvents.Clear();
    }

    protected void RaiseDomainEvents(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}