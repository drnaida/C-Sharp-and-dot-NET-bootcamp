Console.WriteLine("Arithmetic operators");
Console.WriteLine();
Console.WriteLine("Increment and decrement");
int a = 7;
int b = a++;
Console.WriteLine($"a: {a}, b: {b}");

int c = 7;
int d = --c;
Console.WriteLine($"c: {c}, d: {d}");

Console.WriteLine("Comparison operators");
int k = 17;
int l = 15;
Console.WriteLine(k > l);
Console.WriteLine(k < l);
Console.WriteLine(k >= l);
Console.WriteLine(k <= l);

Console.WriteLine("Boolean logical operators");

bool isRegistered = false;
Console.WriteLine($"isRegisterd: {isRegistered}");
Console.WriteLine($"isRegisterd NOT: {!isRegistered}");

bool isWednesday = true;
bool isWeekend = false;
Console.WriteLine(isWednesday && isWeekend);
Console.WriteLine(isWednesday || isWeekend);

Console.WriteLine("Equality operators");
string myName = "Anzhelika";
string myCountry = "USA";
int myLuckyNumber = 16;

Console.WriteLine(myLuckyNumber != 5);
Console.WriteLine(myLuckyNumber == 16);
Console.WriteLine(myName == myCountry);

