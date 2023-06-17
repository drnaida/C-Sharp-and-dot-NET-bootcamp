var rectangle = new Rectangle(200, 300);
Console.WriteLine($"rectangle height: {rectangle.Height}");

MethodParameters.ChangeHeight(ref rectangle);
Console.WriteLine($"rectangle height: {rectangle.Height}");

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