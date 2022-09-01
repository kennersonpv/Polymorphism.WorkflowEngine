using System;

namespace Polymorphism.WorkflowEngine
{
    public class VideoUpload : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video is uploaded");
        }
    }
}