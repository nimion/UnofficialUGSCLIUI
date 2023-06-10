using System.Text.RegularExpressions;

public static class UserInputValidators
{
    public static bool IsValidId(string id)
    {
        return DoesStringMatchRegexPattern(id, @"[0-9A-Fa-f]{8}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{12}");
    }

    public static bool IsValidName(string name)
    {
        return DoesStringMatchRegexPattern(name, @"[A-Za-z0-9_-]");
    }

    private static bool DoesStringMatchRegexPattern(string input, string pattern)
    {
        Regex regex = new Regex(pattern);
        return regex.Match(input).Success;
    }
}
