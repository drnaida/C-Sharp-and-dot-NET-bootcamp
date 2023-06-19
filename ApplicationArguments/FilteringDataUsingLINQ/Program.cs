var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6 };

//deferred query execution with anonymous method
var evenNumbers = numbers.Where(x => x % 2 == 0);

//deferred query execution
var evenNumbers2 = numbers.Where(FilterEvenNumbers);

//if we add toList() or anything else with to, it will make the query
//execute right now and not include 7
//immediate query execution
var evenNumbers3 = numbers.Where(FilterEvenNumbers).ToList();

//still will not see the 7 in evenNumbers and evenNumbers2
numbers.Add(7);
numbers.Add(8);

foreach (int num in evenNumbers)
{
    Console.Write("{0, 1}", num);
}
Console.WriteLine();
foreach (int num in evenNumbers2)
{
    Console.Write("{0, 1}", num);
}
Console.WriteLine();
foreach (int num in evenNumbers3)
{
    Console.Write("{0, 1}", num);
}

static bool FilterEvenNumbers(int num)
{
    return num % 2 == 0;
}