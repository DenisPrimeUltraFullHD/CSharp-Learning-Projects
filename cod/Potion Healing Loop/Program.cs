using System;

namespace cod
{
    class Program
    {
        static void ApplyPotion(ref int health, ref int mana, int healthRestore, int manaRestore)
        {
            health += healthRestore;
            mana += manaRestore;
        }

        static void Main()
        {

            int health = 90;
            int mana = 45;

            int healthRestore = 10;
            int manaRestore = 5;

            for (int i = 0; i < 3; i++)
            {
                ApplyPotion(ref health, ref mana, healthRestore, manaRestore);
            }

            System.Console.WriteLine(health + " " + mana);

        }
    }
}