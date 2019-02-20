using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZIP_FTP.Extenders
{
  public class CustomTasks : Task
  {
    public CustomTasks(Action action) : base(action)
    {
    }

    public CustomTasks(Action action, CancellationToken cancellationToken) : base(action, cancellationToken)
    {
    }

    public CustomTasks(Action action, TaskCreationOptions creationOptions) : base(action, creationOptions)
    {
    }

    public CustomTasks(Action<object> action, object state) : base(action, state)
    {
    }

    public CustomTasks(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : base(action, cancellationToken, creationOptions)
    {
    }

    public CustomTasks(Action<object> action, object state, CancellationToken cancellationToken) : base(action, state, cancellationToken)
    {
    }

    public CustomTasks(Action<object> action, object state, TaskCreationOptions creationOptions) : base(action, state, creationOptions)
    {
    }

    public CustomTasks(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : base(action, state, cancellationToken, creationOptions)
    {
    }
  }
}
