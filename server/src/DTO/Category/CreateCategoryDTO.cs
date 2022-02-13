namespace Bank.Dto;

public class CreateCategoryDTO
{
    public string Name { get; set; } = string.Empty;

    public string Icon { get; set; } = string.Empty;

    public TransactionType Type { get; set; }
}