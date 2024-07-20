using System;
using TemplateMethod.FinancialExample;
using TemplateMethod.WindowExample;

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

            var paint = new PaintWindow();

            paint.Close();

            Console.ReadLine();
        }
    }
}
