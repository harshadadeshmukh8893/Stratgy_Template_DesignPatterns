using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConTemplateDesignPattern.Model
{
    internal class MechanicalDepartment:HiringProcess
    {
        public override void FirstRoundTest()
        {
            Console.WriteLine("Conduct mechanical department test.." + Environment.NewLine);
        }
        public override void TechnicalInterview()
        {
            Console.WriteLine("Conduct Mechanical department technical interview"+ Environment.NewLine);
        }
    }
}
