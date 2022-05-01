Console.Write("Default C# Fibonacci: ");
var fcw = new CSharp.FibonacciConsoleWriter();
fcw.Write(10);
Console.WriteLine();


Console.Write("Functinoal C# Fibonacci: ");
var fibonacci = new CSharp.Fibonacci();
foreach (var item in fibonacci.Get(10))
{
    Console.Write($"{item} ");
}
Console.WriteLine();


Console.Write("F# Fibonacci: ");
foreach (var item in FSharp.Fibonacci.get(10))
{
    Console.Write($"{item} ");
}
Console.WriteLine();
