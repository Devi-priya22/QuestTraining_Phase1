 var names = new List<string>(){"Alpha", "Beta", "Gamma", "Delta"};
var marks = new List<int>(){66,75,88,90};
//var zip = names.Zip(marks);
var zip = names
    .Zip(marks, (name, mark) => {return new {name, mark};})
    .Where(s => s.mark > 80)
    .Select(s => s.name);
    foreach(var i in zip)
    {
        System.Console.WriteLine(i);
    }

