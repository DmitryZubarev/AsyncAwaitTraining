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

    void Callback(Func<Task> action)
    {
    }

    //Ошибка заключалась в том, что в callback в 7 строке мы передаём асинхронный метод, который вернёт Task.
    //В то время как метод был объявлен с делегатом void типа.
}
