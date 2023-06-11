int age = 31;
float weight = 78.7f;

Console.WriteLine($"age: {age}, weight: {weight}");

//implicit conversation
long myAge = age;

//explicit conversion
int lessWeight = (int)weight; //precission loss
int notMyAge = (int)myAge; //no precission loss

long bigNumber = 1111111111111111;
int smallerType = (int)bigNumber;

Console.WriteLine(smallerType);