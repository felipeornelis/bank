namespace Bank.Exceptions;

public class NullRequiredFieldException : Exception
{
    public static string Information = "Todos os campos obrigatórios devem ser preenchidos";
    public NullRequiredFieldException(string? message) : base(message){}
}