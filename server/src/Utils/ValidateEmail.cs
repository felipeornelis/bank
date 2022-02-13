using System.Text.RegularExpressions;

namespace Bank.Utils;

public static class ValidateEmailTool
{
    public static bool ValidateEmail(this string email)
    {
        string match = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        return Regex.IsMatch(email, match);
    }
}