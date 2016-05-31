using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WorkflowConsoleApplication1
{

    public sealed class InputCodeFile : CodeActivity
    {

        // InArgument<string> Text { get; set; }

        public OutArgument<CodeEntity> outArg { get; set; }
     
        protected override void Execute(CodeActivityContext context)
        {

            //string text = context.GetValue(this.Text);

            CodeEntity ce = new CodeEntity();



           
                Console.WriteLine("Enter Employee Name");
                string empName = Console.ReadLine();
                ce.employeeName = empName;


                Console.WriteLine("Enter Employee ID");
                int empID = Int32.Parse(Console.ReadLine());
                ce.employeeID = empID;

                Console.WriteLine("Enter Code File");
                string codeFile = Console.ReadLine();
                ce.codeFile = codeFile;

                Console.WriteLine("Enter if the files contains DB files true/false");
                bool isDBARequired = Boolean.Parse(Console.ReadLine());
                ce.isDBAReviewRequired = isDBARequired;

            
            Console.WriteLine("Has DB errors?");
            bool hasDbErrors = Boolean.Parse(Console.ReadLine());
            ce.hasDBAErrors = hasDbErrors;

            Console.WriteLine("Has Code errors?");
            bool hasCodeErrors = Boolean.Parse(Console.ReadLine());
            ce.hasReviewErrors = hasCodeErrors;

            Console.WriteLine("Has Bugs?");
            bool hasBugs = Boolean.Parse(Console.ReadLine());
            ce.hasBugs = hasBugs;

            outArg.Set(context, ce);
        }
    }
}
