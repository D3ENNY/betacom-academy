namespace startaccademynet4;
internal class MathFunction
{
    /// <summary>
    ///   Overload del metodo computeExponent che accetta un parametro in input e ritorna l'esponente alla base 3
    /// </summary>
    /// <param name="exponent"></param>
    /// <returns></returns>
    internal static double computeExponent(double exponent) => Math.Pow(3, exponent);

    /// <summary>
    /// overload del motodo computeExponent che accetta due parametri in input e ritorna la potenza della base per l'esponente
    /// </summary>
    /// <param name="baseNumber"></param>
    /// <param name="exponent"></param>
    /// <returns></returns>
    internal static double computeExponent(double baseNumber, double exponent) => Math.Pow(baseNumber, exponent);

	/// <summary>
	///  questa funzioni dati 3 parametri in input, n1, n2 e il segno ti fa il calcolo da te richiesto
	/// </summary>
	/// <param name="n1"></param>
	/// <param name="n2"></param>
	/// <param name="sign"></param>
	/// <returns></returns>
    internal static string getCalc(double n1, double n2, string sign){
        switch(sign){
        case "+":
        	return $"result: {n1 + n2}";
        case "-":
            return $"result: {n1 - n2}";
        case "*":
            return $"result: {n1 * n2}";
        case "/":
            if (n2 == 0){
				Console.ForegroundColor = ConsoleColor.Red;
                return "Division by zero is not allowed.";
			}
            return $"{n1 / n2}";
		case "^":
			return $"result: {Math.Pow(n1, n2)}";
        default:
		    Console.ForegroundColor = ConsoleColor.Red;
            return "Invalid operation. Please use +, -, *, or /.";
        }
	}
    
}
