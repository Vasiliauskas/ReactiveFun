namespace ReactiveFun.Testing
{
    using Microsoft.Reactive.Testing;
    using System;
    using System.Reactive.Concurrency;
    class Program
    {
        static void Main(string[] args)
        {
            var scheduler = new TestScheduler();
 
            scheduler.Schedule(TimeSpan.FromTicks(1), () => Console.WriteLine("A"));
            scheduler.Schedule(TimeSpan.FromTicks(10), () => Console.WriteLine("B"));
            scheduler.Schedule(TimeSpan.FromTicks(20), () => Console.WriteLine("C"));
            scheduler.Schedule(TimeSpan.FromTicks(20), () => Console.WriteLine("D"));

            scheduler.AdvanceBy(1);
            Console.ReadLine();
            scheduler.AdvanceBy(10);
            Console.ReadLine();
            scheduler.AdvanceBy(20);
            Console.ReadLine();
        }
    }
}
