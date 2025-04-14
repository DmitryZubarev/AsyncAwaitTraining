namespace Task6;

public class SomeClass
{
    public Task<int> DoSomethingAsync()
    {
        var tcs = new TaskCompletionSource<int>();

        var operation = new LegacyAsyncOperation();
        operation.Completed += result =>
        {
            tcs.SetResult(result);
        };

        return tcs.Task;
    }
}
