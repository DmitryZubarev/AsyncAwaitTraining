namespace Task1
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main()
        {
            var simpleTask = SimpleExample();
            var complexTask = ComplexExample();

            await Task.WhenAll(simpleTask, complexTask);
        }

        public static async Task SimpleExample()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("First!");
                Console.WriteLine("Second");
            });
        }

        public static async Task ComplexExample()
        {
            var task1 = Task.Run(async () =>
            {
                await Task.Delay(2_000);
                Console.WriteLine("In a task");
            });

            var task2 = Task.Run(async () => 
            {
                await Task.Delay(4_000);
                Console.WriteLine("Outside of a task!");
            });

            await Task.WhenAll(task1, task2);
        }
    }
}