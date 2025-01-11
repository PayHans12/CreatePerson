namespace person;

public class Person
{
    public Person(string name, int age, string favoriteColor)
    {
        this.name = name;
        this.age = age;
        this.favoriteColor = favoriteColor;
    }

    public string name {get; set;}
    public int age {get; set;}
    public string favoriteColor {get; set;}

    public string greet()
    {
        return $"Hi my name is {name}, I am {age} years old, and my favorite color is {favoriteColor}";
    }
}