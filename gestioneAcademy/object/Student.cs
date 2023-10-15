
namespace gestioneAcademy;

public class Student
{
    private static int Sid = 0;
    private readonly int ID;
    internal int GetID => ID;
    private readonly string name;
    internal string GetName => name;
    private readonly string surname;
    internal string GetSurname => surname;
    private readonly DateTime bornDate;
    internal string GetDate => bornDate.ToString("dd/MM/yyyy");
    private readonly string studyCourse;
    internal string GetStudy => studyCourse;



    public Student(string name, string surname, DateTime bornDate, string studyCourse)
    {
        this.name = name;
        this.surname = surname;
        this.bornDate = bornDate;
        this.studyCourse = studyCourse;
        this.ID = ++Sid;
    }

    public override string ToString() => $"name: {this.name} - surname: {this.surname} - born date: {this.bornDate} - study course: {this.studyCourse}";
}