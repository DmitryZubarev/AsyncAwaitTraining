namespace Task6;

public class SomeClass
{
    public Task<int> DoSomethingAsync()
    {
        var tcs = new TaskCompletionSource<int>();

        Task<int> operation = new LegacyAsyncOperation();

        operation.ContinueWith(
            baseTask => tcs.SetResult(baseTask.Result),
            TaskContinuationOptions.OnlyOnRanToCompletion);
    }
    //В решении не уверен, но передача значения по событию мне не понравилась)
}
