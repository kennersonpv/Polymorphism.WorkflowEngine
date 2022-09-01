using System;

namespace Polymorphism.WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            engine.AddActivity(new VideoUpload());
            engine.AddActivity(new VideoEncoding());
            engine.AddActivity(new SendEmail());
            engine.AddActivity(new VideoStatus());
            engine.Run();
        }
    }
}