namespace Bank.Exceptions;

public class StatementNotFound : Exception
{
    public static string Information = "Coisas estranhas acontecerem e essa fatura não foi encontrada";
    public StatementNotFound(string? message) : base(message) {}
}