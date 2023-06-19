var persons = new List<Person>
{
    new Person("John", "Deer", 27),
    new Person("John", "Apple", 41),
    new Person("Tim", "Walters", 29),
    new Person("April", "Johnson", 36),
};

var lastNames = persons.Select(person => person.LastName);

foreach (var lastname in lastNames)
{
    Console.WriteLine(lastname);
}

var ageBetween20and30 = persons
    .Where(person => person.Age >= 20 && person.Age <= 30)
    .Select(person => person.Age);

foreach (var age in ageBetween20and30)
{
    Console.WriteLine(age);
}

var firstPerson = persons.First();
Console.WriteLine(firstPerson.FirstName);

//first or default if there is no elements in collection,
//intead of throwing an error, it will return default value
var firstPerson2 = persons.FirstOrDefault();
Console.WriteLine(firstPerson2.FirstName);

var firstPerson3 = persons.Single();
Console.WriteLine(firstPerson3.FirstName);

var firstPerson4 = persons.SingleOrDefault();
Console.WriteLine(firstPerson4.FirstName);

foreach (var person in persons.Skip(1).Take(2))
{
    Console.WriteLine(person.FirstName);
}

record Person(string FirstName, string LastName, int Age);