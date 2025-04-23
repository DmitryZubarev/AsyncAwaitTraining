public class MyLibrary
{
    public Task<int> AddAsync(int a, int b)
    {
        return Task.FromResult(a + b);
    }
    //Ошибка в выделении потока для простейшей операции.
}