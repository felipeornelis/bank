namespace Bank.Exceptions;

public class InvalidStatementSituationException : Exception
{
    public static string Information = "Situação inválida para uma fatura. Ou tá paga, ou não. Apenas isso.";
    public InvalidStatementSituationException(string? message) : base(message) {}
}