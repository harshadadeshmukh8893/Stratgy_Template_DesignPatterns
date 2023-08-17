using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConTemplateDesignPattern.Model
{
    public abstract class HiringProcess
    {
        public void HiringFresher()
        {
            FirstRoundTest();
            GroupDiscussion();
            TechnicalInterview();
            HRInterview();
        }
        public abstract void FirstRoundTest();
        private void GroupDiscussion()
        {
            Console.WriteLine("Conduct group discussion "+ Environment.NewLine);
        }
        public abstract void TechnicalInterview();

        public void HRInterview()
        {
            Console.WriteLine("Conduct HR interview "+ Environment.NewLine);
        }
    }
}
