public class MyLibrary
{
    public Task<int> AddAsync(int a, int b)
    {
        return Task.Run(() => a + b);
    }
}