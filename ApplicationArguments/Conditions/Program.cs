// if 
int myLuckyNumber = 16;

if (myLuckyNumber == 16)
{
    Console.WriteLine("You are lucky");
}

// if else

if (myLuckyNumber == 16)
{
    Console.WriteLine("You are lucky");
} else
{
    Console.WriteLine("Unlucky.");
}

// if else if

if (myLuckyNumber == 16)
{
    Console.WriteLine("You are lucky");
}
else if (myLuckyNumber < 16)
{
    Console.WriteLine("Lower");
} else
{
    Console.WriteLine("Higher");
}


int version = 4;
string productVersion = version == 4 ? "4.0" : "3.0";
Console.WriteLine(productVersion);

//switch statemenets
Console.WriteLine("Enter your age: ");
string? input = Console.ReadLine();
int age = int.Parse(input);

switch (age)
{
    case < 10:
        Console.WriteLine("You are a child");
        break;
    case < 20:
        Console.WriteLine("Yoou are a teanager");
        break;
    case < 30:
        Console.WriteLine("You are a young adult");
        break;
    case < 40:
        Console.WriteLine("You are an adult");
        break;
    case < 50:
        Console.WriteLine("You are still an adult");
        break;
    default:
        Console.WriteLine("You are a wise person.");
        break;
}

switch (age)
{
    case 10:
    case 20:
    case 30:
    case 40:
    case 50:
    case 60:
        Console.WriteLine("You just had a round birthday.");
        break;
    default:
        Console.WriteLine("You just had a normal birthday.");
        break;
}