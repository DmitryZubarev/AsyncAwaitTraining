namespace Task5;
public class SomeClass
{
    public async Task<int> DoSomethingAsync()
    {
        var result = await CallDependencyAsync();
        return result++;
    }
    //.ContinueWith() имеет смысл использовать при обработке разных сценариев выполнения основной задачи.
    //Например 1 сценарий при успешном выполнении таски. 2 сценарий при исключении.
    //В данном случае нет никакого ветвления, поэтому лучше просто прописать await.
}
