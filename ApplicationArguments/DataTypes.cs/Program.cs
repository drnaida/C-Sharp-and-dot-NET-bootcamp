using System.Reflection.Metadata;
using System.Runtime.InteropServices;

bool enabled = false;
Console.WriteLine($"bool: {enabled}");

enabled = true;
Console.WriteLine($"bool: {enabled}");

char c1 = 'a';
Console.WriteLine($"char: {c1}");

int a = 0;
int b = 5;
int c = -7;

Console.WriteLine($"a: {a}, b: {b}, c: {c}");

//arithmetic operations
int multiply = b * c;
int divide = c / b;
int add = a + b;
int substract = a - b;
Console.WriteLine($"multiply: {multiply}, divide: {divide}, add: {add}, substract: {substract}");

//long
long i = 99;
Console.WriteLine($"long: {i}");

// floating point number types
float f = 3.5f;
double g = 7.8d;
decimal dec = 7.15m;

Console.WriteLine($"f: {f}, g: {g}, dec: {dec}");

Console.WriteLine($"float calculation: {1.1111111f / 0.8324234f}");
Console.WriteLine($"float calculation: {1.1111111d / 0.8324234d}");
Console.WriteLine($"float calculation: {1.1111111m / 0.8324234m}");

//copying values
int a1 = 7;
int a2 = a1;
a1 = 5;
Console.WriteLine($"a1: {a1}, a2: {a2}");

//Nullable value types
int? i1 = null;
bool? b1 = null;
Console.WriteLine($"int?: {i1}, bool? {b1}");