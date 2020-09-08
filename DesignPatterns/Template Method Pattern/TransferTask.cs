using System;

namespace DesignPatterns.Template_Method_Pattern
{
    public class TransferTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Executing transfer task...");
        }
    }
}