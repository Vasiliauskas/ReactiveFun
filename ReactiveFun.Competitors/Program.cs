namespace ReactiveFun.Competitors
{
    using System;
    using System.Linq;
    using System.Reactive.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Distinct Observable: {typeof(Observable).GetMethods().Select(m => m.Name).Distinct().Count()}"); 
            Console.WriteLine($"Distinct Enumerable: {typeof(Enumerable).GetMethods().Select(m => m.Name).Distinct().Count()}");
            Console.WriteLine($"Total Observable: {typeof(Observable).GetMethods().Select(m => m.Name).Count()}");
            Console.WriteLine($"Total Enumerable: {typeof(Enumerable).GetMethods().Select(m => m.Name).Count()}");
            Console.ReadLine();
        }
    }
}
