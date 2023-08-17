using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStratgyDesignPattern
{
    internal class KnightAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Knight slashes with sword!");
        }
    }
}
