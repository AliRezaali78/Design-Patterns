using System;

namespace DesignPatterns.Template_Method_Pattern
{
    public class EasiestTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Executing Easiest task in the world...");
        }
    }
}