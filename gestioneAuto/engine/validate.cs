using System.Text.RegularExpressions;

namespace gestioneAuto;

class Validate{
    protected bool ValidateText(String text){
        const string regex = @"^[a-zA-Z\u00C0-\u00FF\d\s]+$";
        return Regex.IsMatch(text.Trim(), regex) && !string.IsNullOrWhiteSpace(text);
    }
    protected bool ValidateNullText(String text){
        const string regex = @"^[a-zA-Z\u00C0-\u00FF\s]+$";
        return Regex.IsMatch(text.Trim(), regex) || string.IsNullOrWhiteSpace(text);
    }
    protected bool ValidateChassisNumber(string chassisNumber){
        const string regex = @"^[a-z]{3}\d{5}$";
        return Regex.IsMatch(chassisNumber.Trim(), regex) && !string.IsNullOrEmpty(chassisNumber);
    }

    protected bool ValidateYear(string year){
        const string regex = @"^\d{4}$";
        int.TryParse(year, out int tmp);
        return Regex.IsMatch(year.Trim(), regex) && tmp < DateTime.Now.Year && tmp >= 1890;
    }
    protected bool ValidateCubiCapacity(string cubiCapacity){
        const string regex = @"^\d{4}$";  
        int.TryParse(cubiCapacity, out int tmp);
        return Regex.IsMatch(cubiCapacity.Trim(), regex) && tmp > 50 && tmp < 7000;
    }

    protected bool ValidateRangeNumber(string number, int s, int e){
        string regex = $"^[{s}-{e}]$";
        return Regex.IsMatch(number.Trim(), regex);
    }
}