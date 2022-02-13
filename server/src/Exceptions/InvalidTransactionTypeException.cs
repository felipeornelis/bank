namespace Bank.Exceptions;

public class InvalidTransactionTypeException : Exception
{
    public static string Information = "Tipo de transação inválido. Selecione despesa ou receita";
    public InvalidTransactionTypeException(string? message) : base(message) {}
}