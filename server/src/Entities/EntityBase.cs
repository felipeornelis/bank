namespace Bank.Entities;

public class EntityBase
{
    public Guid Id { get; }
    public DateTime CreatedAt { get; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public EntityBase()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
    }
}