using System;

class Pet
{
    private string _name;
    private int _age;
    private string _type;
    private bool _isFed;

    public Pet(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name cannot be empty!");
        this._name = name;
        this._age = 1;
        this._type = "Unknown";
        this._isFed = false;
    }
    public Pet(string name, int age) : this(name)
    {
        this._age = (age > 0 && age <= 20) ? age : 1;
    }
    public Pet(string name, int age, string type) : this(name, age)
    {
        if (string.IsNullOrEmpty(type)) throw new ArgumentException("Type cannot be empty!");
        this._type = type;
    }
    public Pet(string name, int age, string type, bool isFed) : this(name, age, type)
    {
        this._isFed = isFed;
    }

    public void Print()
    {
        string status = _isFed ? "Yes" : "No";
        Console.WriteLine($"Pet - Name: {_name}, Type: {_type}, Age: {_age}, Fed: {status}");
    }
    public void Feed()
    {
        Console.WriteLine("\nI feed pet...");
        Console.WriteLine("Cool! Pet fed");
        _isFed = true;
    }
}
class Program
{
    static void Main()
    {
        Pet pet1 = new Pet(name: "Rio");
        Pet pet2 = new Pet(name: "Lapochka", age: 9);
        Pet pet3 = new Pet(age: 9, name: "Vesta", type: "dog", isFed:false);
        
        pet1.Print();
        pet2.Print();
        pet3.Print();
        pet3.Feed();
        pet3.Print();
    }
}