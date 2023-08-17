namespace POCStratgyDesignPattern
{
    using System;

    internal class program
    {
        public static void Main(string[] args)
        {
            Character knight = new Character("Sir Lancelot", new KnightAttack());
            Character wizard = new Character("Gandalf", new WizardAttack());

            knight.Attack();  
            wizard.Attack();  

            // Changing strategy at runtime
            knight.SetAttackStrategy(new WizardAttack());
            knight.Attack();  
        }

    }


}