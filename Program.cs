using System;
using System.Security.Cryptography.X509Certificates;

namespace Polymorphism.WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorkflow workflow = new Workflow();
            workflow.AddActivity(new VideoUpload());
            workflow.AddActivity(new VideoEncoding());
            workflow.AddActivity(new SendEmail());
            workflow.AddActivity(new VideoStatus());

            IWorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}