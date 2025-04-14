using Microsoft.AspNetCore.Mvc;

public class MyController : Controller
{
    [HttpPost("/start")]
    public IActionResult Post()
    {
        BackgroundOperationAsync();
        return Accepted();
    }

    public async Task BackgroundOperationAsync()
    {
        var result = await CallDependencyAsync();
        DoSomething(result);
    }

    //Ошибка в использовании async void.
    //Также можно добавить обработку ошибок, но будто бы по примеру нет необходимости обрабатывать ошибки.
}