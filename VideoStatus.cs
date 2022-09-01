using System;

namespace Polymorphism.WorkflowEngine
{
    public class VideoStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Status: Processing");
        }
    }
}