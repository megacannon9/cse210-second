using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main()
    {
        Person myPerson = new Person("Bob","Floyd",18,114);
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice = new Police("Lance","Pim", 34, 200,"Death");
        Console.WriteLine(myPolice.GetPoliceInformation());

        Doctor myDoctor = new Doctor("Jacob","Michelsen", 35, 200, "Stethoscope");
        Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

    foreach(Person person in myPeople)
        {
            Console.WriteLine(person.GetPersonInformation());
        }
    }
}