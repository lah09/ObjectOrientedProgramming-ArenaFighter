using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter

{
    class Battle : Character  //accessing variables from Class Character
    {

        Round r = new Round(); //instance for Class Round
        public int hPoints, vPoints;
        public int hHealth, vHealth;

        public void battle(int strength, int health, int damage, int vstrength, int vhealth, int vdamage, int hPoints, int vPoints, string randomMonster)
        /*accessing variables from other Class otherwise error*/
        {
            try
            {
                Random rand2 = new Random();  //random for dice

                r.d1 = rand2.Next(1, 6);    //random for dice
                r.d2 = rand2.Next(1, 6);    //random for dice
                hPoints = ((strength + health) - vdamage);  //you can write better Mathematical computation
                vPoints = ((vstrength + vhealth) - damage);
                r.hScore = (hPoints + r.d1);
                r.vScore = (vPoints + r.d2);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Rolls: {name} ({r.hScore}={hPoints}+{r.d1}) vs {randomMonster} ({r.vScore}={vPoints}+{r.d2})");
                Console.ResetColor();

                while (true)
                {
                    if (hPoints > vPoints)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(name + " has advantage over opponent!");
                        Console.WriteLine(randomMonster + " got a hard blow from " + name);
                        Console.ResetColor();
                        break;
                    }

                    else if (hPoints >= 13 && vPoints >= 13)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Evenly matched, the combatant circle each other, looking for a better opportunity");
                        Console.ResetColor();
                        break;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(name + " is getting defeated!");
                        Console.WriteLine(name + " got {0} damage from {1}", vdamage, randomMonster);
                        Console.ResetColor();
                        break;
                    }
                }

                hHealth = hPoints - vdamage;
                hHealth = Math.Max(0, hHealth); //avoid negative number
                vHealth = vPoints - damage;
                vHealth = Math.Max(0, vHealth);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Remaining Health: {0}({1}), {2}({3})", name, hHealth, randomMonster, vHealth);
                Console.ResetColor();

                if (hHealth == 0 || vHealth == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game Over! One/Both - 0 health");
                    Console.ResetColor();
                }
            }

            catch
            {
                Console.WriteLine("Something went wrong!");
            }
        }
    }
}