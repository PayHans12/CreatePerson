using person;

string name;
int age;
string color;

for (int i = 0; i < 2; i++)
{
    Console.Write("Please enter your name: ");
    name = Console.ReadLine();

    Console.Write("What is your age: ");
    while (true)
    {
        try
        {
            age = int.Parse(Console.ReadLine());
            break;
        }
        catch
        {
            Console.Write("Please enter a valid number: ");
        }
    }

    Console.Write("What is your favorite Color: ");
    color = Console.ReadLine();

    Person person = new Person(name, age, color);

    Console.WriteLine(person.greet());
}

Person bob = new Person("Bob", 14, "Blue");
Person ally = new Person("Ally", 28, "Green");
Console.WriteLine(bob.greet());
Console.WriteLine(ally.greet());

