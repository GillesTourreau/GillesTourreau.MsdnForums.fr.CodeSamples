using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace _6b127f39_2d48_498f_915b_c0dd6b384653
{

    class Program
    {
        static void Main(string[] args)
        {
            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);
        }
    }
}
