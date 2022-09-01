using System;

namespace Polymorphism.WorkflowEngine
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Email is sent");
        }
    }
}