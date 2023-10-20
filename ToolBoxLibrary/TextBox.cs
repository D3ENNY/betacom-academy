namespace ToolBoxLibrary.TextBox;

public static class TextBox
{
    public static string Capitalize(this string str) => 
        str switch
        {
            null => throw new ArgumentNullException(nameof(str)),
            "" => throw new ArgumentException($"{nameof(str)} cannot be empty", nameof(str)),
            _ => string.Concat(str[0].ToString().ToUpper(), str.AsSpan(1))
        };
}
