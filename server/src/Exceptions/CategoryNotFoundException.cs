namespace Bank.Exceptions;

public class CategoryNotFoundException : Exception
{
    public static string Information = "Categoria não encontrada";
    public CategoryNotFoundException(string? message) : base(message) {}
}