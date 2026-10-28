class Doctor : Person
{
    private string _equipment;

    public Doctor(string firstName, string lastName, int age, double weight, string equimpent)
    : base (firstName,lastName,age,weight)
    {
        _equipment = equimpent;
    }

    public string GetDoctorInformation()
    {
        return $"Doctor: {GetPersonInformation()} Tools: {_equipment}";
    }
}