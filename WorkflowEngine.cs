using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Polymorphism.WorkflowEngine
{
    public class WorkflowEngine : IWorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                try
                {
                    activity.Execute();
                }
                catch (Exception)
                {
                    
                }
            }
        }
    }
}