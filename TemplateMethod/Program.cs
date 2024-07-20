using System;
using TemplateMethod.FinancialExample;

namespace TemplateMethod
{
    internal abstract class Program
    {
        private static void Main()
        {
            var transferTask = new TransferMoneyTask(new AuditTrail());

            transferTask.Execute();

            var reportTask = new GenerateReportTask();

            reportTask.Execute();
            
            Console.ReadLine();
        }
    }
}
