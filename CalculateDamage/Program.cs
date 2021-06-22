using System;

namespace CalculateDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new();
            Random random = new();

            while (true)
            {
                // Heading and input
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char selection = Console.ReadKey().KeyChar;
                
                // Sets roll field
                int roll3d6 = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.Roll = roll3d6;

                switch (selection)
                {
                    case '0':
                        swordDamage.SetMagic(false);
                        swordDamage.SetFlaming(false);
                        break;
                    case '1':
                        swordDamage.SetMagic(true);
                        swordDamage.SetFlaming(false);
                        break;
                    case '2':
                        swordDamage.SetMagic(false);
                        swordDamage.SetFlaming(true);
                        break;
                    case '3':
                        swordDamage.SetMagic(true);
                        swordDamage.SetFlaming(true);
                        break;
                    default:
                        return;
                }

                swordDamage.CalculateDamage();
                Console.WriteLine("\nRolled {0} for {1} HP\n", swordDamage.Roll, swordDamage.Damage);
            }
        }
    }
}
