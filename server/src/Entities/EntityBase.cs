namespace Bank.Entities;

public class EntityBase
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public EntityBase()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
    }
}