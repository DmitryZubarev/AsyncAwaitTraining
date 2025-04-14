using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5;
public class SomeClass
{
    public Task<int> DoSomethingAsync()
    {
        return CallDependencyAsync().ContinueWith(task =>
        {
            return task.Result + 1;
        });
    }
}
