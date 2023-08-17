using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConTemplateDesignPattern.Model
{
    internal class CSEDepartment:HiringProcess
    {
        public override void FirstRoundTest()
        {
            Console.WriteLine("Conduct CSE department Test "+ Environment.NewLine);
        }
        public override void TechnicalInterview()
        {
            Console.WriteLine("Conduct CSE department technical interview " + Environment.NewLine);
        }
    }
}
