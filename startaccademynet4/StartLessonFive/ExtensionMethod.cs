namespace startaccademynet4;

internal static class ExtensionMethod
{
    internal static int WordCounts(this string s){
        return s.Split(
            new char[]{' ', ',', '.', ';'},
            StringSplitOptions.RemoveEmptyEntries
        ).Length;
    }
}   