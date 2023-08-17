using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStratgyDesignPattern
{
    internal class WizardAttack:IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Wizard casts a spell!");
        }
    }
}
