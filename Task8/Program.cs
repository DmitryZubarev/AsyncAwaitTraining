

var toDoTasks = new List<OurTask>();
IEnumerable<Task<int>> taskListQuery = from toDoTask in toDoTasks select DoSomething(ourTask);

List<Task<int>> taskList = taskListQuery.ToList();

while (taskList.Count > 0)
{
    Task<int> firstFinishedTask = await Task.WhenAny(taskList);
    downloadTasks.Remove(firstFinishedTask);
    int taskList = await firstFinishedTask;
}

Task<int> DoSomething(OurTask ourTask)
{
    return Task.Run(() =>
    {
        //Твой код здесь
        return 1;
    });
}