namespace Task7;

public class SomeClass
{
    void DoSomething()
    {
        Callback(async () =>
        {
            await Task.Yield();
        });
    }

    void Callback(Action action)
    {
    }
}
