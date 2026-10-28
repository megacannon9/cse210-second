using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main()
    {
        Person myPerson = new Person("Bob","Floyd",18,114);

        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice = new Police("Lance","Pig", 34, 200,"Death");
        
        Console.WriteLine(myPolice.GetPoliceInformation());
    }
}