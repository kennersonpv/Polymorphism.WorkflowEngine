using System.Collections.Generic;

namespace Polymorphism.WorkflowEngine
{
    public interface IWorkflow
    {
        void AddActivity(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}