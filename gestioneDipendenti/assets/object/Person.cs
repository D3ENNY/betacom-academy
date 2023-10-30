namespace gestioneDipendenti.obj;

internal class Person
{
    internal abstract class PersonData
    {
        public abstract string RegisterId{get;set;}
        public abstract string Nominative{get;set;}
        public abstract int Age{get;set;}
        public abstract string Address{get;set;}
        public abstract string City{get;set;}
        public abstract string Province{get;set;}
        public abstract string Cap{get;set;}
        public abstract int PhoneNumber{get;set;}
    }
}