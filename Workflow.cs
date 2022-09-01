using System.Collections.Generic;

namespace Polymorphism.WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activity;

        public Workflow()
        {
            _activity = new List<IActivity>();
        }
        
        public void AddActivity(IActivity activity)
        {
            _activity.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activity;
        }
    }
}