class Program
{
    static void Main()
    {
        Person myPerson = new Person("Bob","Floyd",18,114);

        myPerson.DisplayPersonInformation();

        Police myPolice = new Police("Lance","Pig", 34, 200,"Death");
        
        myPolice.DisplayPersonInformation();
    }
}