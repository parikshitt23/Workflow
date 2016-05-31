using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowConsoleApplication1
{
    public class CodeEntity
    {
        public string employeeName { get; set; }

        public int employeeID { get; set; }

        public string codeFile { get; set; }

        public bool isDBAReviewRequired { get; set; }

        public bool hasDBAErrors { get; set; }

        public bool hasReviewErrors { get; set; }

        public bool hasBugs { get; set; }

        public string dbaReviewComments { get; set; }

        public string codeReviewComments { get; set; }

        public string testBugs { get; set; }
    }
}
