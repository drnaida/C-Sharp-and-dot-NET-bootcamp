Person person1 = new Person("Claudio");
Person person2 = new Person("John");

person1.Name = "Test";
person1.PrintGreeting();

string greeting = person1.GetGreeting();
Console.WriteLine(greeting);

Math math = new Math();
int result = math.Sum(14, 16);

/*class Person
{
    private string _name;
    public Person()
    {
        _name = "Claudio";
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}*/

class Person
{
    //constructor says what info is required to create a class
    public Person(string name)
    {
        Name = name;
    }

    //getter and setter
    public string Name { get; set; }

    //method that returns nothing
    public void PrintGreeting()
    {
        Console.WriteLine($"Hello, {Name}!");
    }

    //method that returns a string
    public string GetGreeting()
    {
        return $"Hello, {Name}";
    }
}

public class Math
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}