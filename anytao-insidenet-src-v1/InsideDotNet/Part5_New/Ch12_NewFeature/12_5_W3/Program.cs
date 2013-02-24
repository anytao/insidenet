// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.W3
// Release     : 2007/12/16 1.0
// Description : 12.5  江湖一统：WPF、WCF、WF

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;

namespace InsideDotNet.NewFeature.W3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(WorkflowRuntime workflowRuntime = new WorkflowRuntime())
            {
                AutoResetEvent waitHandle = new AutoResetEvent(false);
                workflowRuntime.WorkflowCompleted += delegate(object sender, WorkflowCompletedEventArgs e) {waitHandle.Set();};
                workflowRuntime.WorkflowTerminated += delegate(object sender, WorkflowTerminatedEventArgs e)
                {
                    Console.WriteLine(e.Exception.Message);
                    waitHandle.Set();
                };

                WorkflowInstance instance = workflowRuntime.CreateWorkflow(typeof(myWF));
                instance.Start();

                waitHandle.WaitOne();
            }
        }
    }
}
