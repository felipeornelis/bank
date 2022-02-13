namespace Bank.Entities;

public class Institution : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public string Compensation { get; set; } = string.Empty;

    public string Icon { get; set; } = string.Empty;
}