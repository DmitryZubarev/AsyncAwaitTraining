var result = Task.Run(async () =>
{
    await Task.Delay(5_000);
    Console.WriteLine("Task completed");
});

Console.WriteLine("Outside task");
await Task.Delay(10_000);

//var result = Task.FromResult(async () =>
//{
//    await Task.Delay(5_000);
//    Console.WriteLine("Task completed");
//});

//var exceptionResult = Task.FromException(async () =>
//{
//    await Task.Delay(5_000);
//    Console.WriteLine("Task completed");
//});
