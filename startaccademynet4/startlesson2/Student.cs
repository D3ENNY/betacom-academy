namespace startaccademynet4;
public class Student
{
    private static readonly Student[] students =  new Student[5];
    private static readonly List<Student> studentsList = new();
    private static int id = 0;
    public int Id { get; set; }
    public String Name { get; set; }
    public String  LastName { get; set; }

    // public Student(){
    //     Id = 0;
    //     Name = string.Empty;
    //     LastName = string.Empty;
    // }

    public Student(string Name, string LastName){
        this.Id = ++id; 
        this.Name = Name;
        this.LastName = LastName;
        //students[this.Id] = this;
        //studentsList.Add(this);
    }

    public override string ToString(){
        return $"ID: {this.Id}\nname: {this.Name}\nsurname: {this.LastName}";
    }

    public static string ShowStudentsArray(){
        string returnStr = "";
        foreach (Student s in Student.students)
        {
            if(s != null)
                returnStr += $"ID: {s.Id}\nname: {s.Name}\nsurname: {s.LastName}\n----\n";
        }
        return returnStr;
    }

    public static string showStudentsList(){
        string returnStr = "";
        studentsList.ForEach(x => returnStr += $"ID: {x.Id}\nname: {x.Name}\nsurname: {x.LastName}\n----\n");
        return returnStr;
    }
}
