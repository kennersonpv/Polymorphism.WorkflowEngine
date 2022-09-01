using System;

namespace Polymorphism.WorkflowEngine
{
    public class VideoEncoding : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video is ready for encoding");
        }
    }
}