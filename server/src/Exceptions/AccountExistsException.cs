namespace Bank.Exceptions;

public class AccountExistsException : Exception
{
    public static string Information = "Você já criou uma conta com esse nome. Preste atenção!";
    public AccountExistsException(string? message) : base(message) {}
}