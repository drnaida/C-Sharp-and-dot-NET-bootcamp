string message = "Hello world!";
Console.WriteLine(message);

//empty string
string emptyMessage = string.Empty;

string stringWithDoubleQuote = "This is a string with a double quote \" ";
Console.WriteLine(stringWithDoubleQuote);

string filePath = "C:\\temp";
Console.WriteLine(filePath);

string filePath2 = @"C:\temp";
Console.WriteLine(filePath2);

//string length
Console.WriteLine(filePath.Length);

//string concatenation
string firstName = "Anzhelika";
string lastName = "Kurnikova";

string fullName = firstName + " " +  lastName;
Console.WriteLine(fullName);

//string interpolation
string fullNameInterpolated = $"{firstName} {lastName}";
Console.WriteLine(fullNameInterpolated);
Console.WriteLine($"The result is {5 * 7}");

//substrings
string first5Characters = fullName.Substring(0, 5);
Console.WriteLine(first5Characters);