using POConTemplateDesignPattern.Model;

namespace POConTemplateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HiringProcess process = new MechanicalDepartment();

            Console.WriteLine("***Hiring Mechanical Students***" + Environment.NewLine);
            process.HiringFresher();

            HiringProcess hiringProcess = new CSEDepartment();

            Console.WriteLine("***Hiring CSE Students***" + Environment.NewLine);
            process.HiringFresher();
        }
    }
}