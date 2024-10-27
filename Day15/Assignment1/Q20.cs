 var names = new List<string> {"Alice", "Bob", "Charlie"};
var age = new List<int> {8, 2, 7};
var pairs = names.Zip(age, (names, age) => new { Name = names, Age = age});
foreach (var pair in pairs)
    {
        Console.WriteLine($"Name: {pair.Name}, Age: {pair.Age}");
    }