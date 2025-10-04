Pet Class: OOP Task
This C# console application demonstrates object-oriented programming (OOP) concepts through a Pet class, focusing on constructor overloading and clean code practices.
Project Overview
The Pet class represents a pet with attributes like name, age, type, and fed status. It showcases:

Private fields with _ prefix for encapsulation.
Overloaded constructors with input validation.
Named arguments for readable object creation.
Chained constructors (: this()) to avoid code duplication (DRY).
Methods to manipulate and display the pet's state.

Pet Class

Fields:

_name (string): Pet's name.
_age (int): Age (1–20).
_type (string): Pet type (e.g., "Dog", "Cat").
_isFed (bool): Whether the pet is fed.


Constructors:

Pet(name): Sets name, defaults age to 1, type to "Unknown", fed to false.
Pet(name, age): Sets name and age, defaults type and fed.
Pet(name, age, type): Sets name, age, type, defaults fed.
Pet(name, age, type, isFed): Sets all fields.
Validates: name and type not empty, age (1–20).


Methods:

Print(): Outputs pet info (e.g., Pet - Name: Rio, Type: Unknown, Age: 1, Fed: No).
Feed(): Marks pet as fed and prints confirmation.


Example Usage:
Pet pet1 = new Pet(name: "Rio");
Pet pet2 = new Pet(name: "Lapochka", age: 9);
Pet pet3 = new Pet(name: "Vesta", age: 9, type: "dog", isFed: false);
pet1.Print();
pet2.Print();
pet3.Print();
pet3.Feed();
pet3.Print();



How to Run

Ensure you have a C# environment (e.g., .NET SDK, Visual Studio, Rider).
Copy the code into a .cs file (e.g., Pet.cs).
Run the program:dotnet run


The console will display:Pet - Name: Rio, Type: Unknown, Age: 1, Fed: No
Pet - Name: Lapochka, Type: Unknown, Age: 9, Fed: No
Pet - Name: Vesta, Type: dog, Age: 9, Fed: No
I feed pet...
Cool! Pet fed
Pet - Name: Vesta, Type: dog, Age: 9, Fed: Yes



Key Learning Points

Encapsulation using private fields with _ prefix.
Constructor overloading for flexible object creation.
Input validation to ensure valid object state.
Clean code: DRY with chained constructors, readable method names, named arguments.

Future Improvements

Add validation for negative age with exceptions (after learning try-catch).
Introduce an enum for pet types (e.g., Dog, Cat).
Extend with methods like AgeUp to increase age.

