namespace gestioneDipendenti.obj;
class Person
{
    public string? matricola{get;set;}
    public string? n2{get;set;}
    public string? n3{get;set;}
    public string? n4{get;set;}
    public string? n5{get;set;}
    public string? n6{get;set;}
    public string? n7{get;set;}
    public string? n8{get;set;}
    public string? n9{get;set;}
    public string? n10{get;set;}

    public override string ToString() => $"matricola: {matricola}\n{n2} - {n3} - {n4} - {n5} - {n6} - {n7} - {n8} - {n9} - {n10}";
}