var person = new Person("Liam");
Console.WriteLine($"Name: {person.Name}");

MethodParameters.ChangeName(ref person);
Console.WriteLine($"Name: {person.Name}");

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}

public struct Rectangle
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; set; }
    public double Height { get; set; }

}

public class MethodParameters
{
    public static void ChangeName(ref Person person)
    {
        person.Name = "Unknown";
        person = new Person("Anzhelika");
    }
    public static void ChangeHeight(ref Rectangle rectangle)
    {
        rectangle.Height = 500;
        Console.WriteLine($"rectangle height in method: {rectangle.Height}");
    }
}

public readonly struct ImmutableRectangle
{
    public ImmutableRectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; init; }
    public double Height { get; init; }
}