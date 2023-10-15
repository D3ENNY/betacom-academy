namespace gestioneAcademy;
using System.Text.RegularExpressions;

public class Validator{
    protected bool ValidateText(String name){
        const string regex = @"^[a-zA-Z\u00C0-\u00FF\s]+$";
        return Regex.IsMatch(name.Trim(), regex) && !string.IsNullOrWhiteSpace(name);
    }

    protected bool ValidateDate(string date){
        const string regex = @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$";
        return Regex.IsMatch(date.Trim(), regex) && !string.IsNullOrWhiteSpace(date);
    }

    protected bool ValidateDate(DateTime date) =>  (DateTime.Compare(date, DateTime.Today) < 0 || DateTime.Compare(date, DateTime.Today) == 0) && 
                                                    DateTime.Compare(date, DateTime.Today.AddYears(-120)) > 0;

}