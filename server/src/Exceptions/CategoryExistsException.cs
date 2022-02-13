namespace Bank.Exceptions;

public class CategoryExistsException : Exception
{
    public static string Information = "Já existe uma categoria para esse tipo de transação.";
    public CategoryExistsException(string? message) : base(message) {}
}