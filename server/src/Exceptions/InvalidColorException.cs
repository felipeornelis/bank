namespace Bank.Exceptions;

public class InvalidColorException : Exception
{
    public static string Information = "Cor inválida. Você não tem todo esse poder pra escolher a sua própria cor.";
    public InvalidColorException(string? message) : base(message) {}
}