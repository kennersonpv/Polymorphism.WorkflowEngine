using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Polymorphism.WorkflowEngine
{
    public class Engine
    {
        private readonly IList<IActivity> _activity;

        public Engine()
        {
            _activity = new List<IActivity>();
        }

        public void Run()
        {
            foreach (var activity in _activity)
            {
                activity.Execute();
            }
        }

        public void AddActivity(IActivity activity)
        {
            _activity.Add(activity);
        }
    }
}