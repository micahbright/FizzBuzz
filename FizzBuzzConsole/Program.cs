// See https://aka.ms/new-console-template for more information
using fizzbuzz;
var fb = new List<Tuple<int, string>>()
{
    Tuple.Create<int, string>(3, "Fizz"),
    Tuple.Create<int, string>(5, "Buzz"),
};
var fboutput = FizzBuzzClass.FizzBuzz(20, fb);
foreach(var str in fboutput)
{
    Console.WriteLine(str);
}

