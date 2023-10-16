namespace startaccademynet4;

class Car
{
    readonly int id ;
    readonly string name="";

    internal Car(int id, string name){
        this.id = id;
        this.name = name;
    }
}

sealed class Supercar : Car    //ereditarietà - sealed => non può esser ereditata
{
    internal int power {get; set;}

    internal Supercar(int id, string name) : base(id, name)
    {
        
    }
}
