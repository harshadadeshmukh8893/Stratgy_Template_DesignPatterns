using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStratgyDesignPattern
{
    internal class Character
    {
        private string _name;
        private IAttack _attackStrategy;

        public Character(string name, IAttack attackStrategy)
        {
            _name = name;
            _attackStrategy = attackStrategy;
        }

        public void SetAttackStrategy(IAttack attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void Attack()
        {
            Console.Write($"{_name} attacks: ");
            _attackStrategy.Attack();
        }
    }
}
