namespace ReactiveFun
{
    using System;
    using System.Reactive.Linq;
    using System.Reactive.Subjects;
    class Program
    {
        static void Main(string[] args)
        {
            ISubject<string> resultingSequence;

            resultingSequence = new Subject<string>();
            resultingSequence.Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));

            resultingSequence.OnNext("A");
            resultingSequence.OnNext("B");
            resultingSequence.OnNext("C");
            resultingSequence.OnCompleted();

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
