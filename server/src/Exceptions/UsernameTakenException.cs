namespace Bank.Exceptions;

public class UsernameTakenException : Exception
{
    public static string Information = "Alguém registrou esse usuário primeiro.";
    public UsernameTakenException(string? message) : base(message) {}
}