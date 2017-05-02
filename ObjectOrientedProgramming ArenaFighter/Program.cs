using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Arena_Fighter
{
    public class Program : Character
    {
        public static char answer = 'y';

        public static void Main(string[] args)
        {
            try
            {
                Character c = new Character();

                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Name: " + name);
                c.RandomNumbers();
                Console.WriteLine("\nWhat do you want to do? ");
                Console.WriteLine("H - Hunt an opponent");
                Console.WriteLine("R - Retire from the game");
                c.choice = Console.ReadKey().KeyChar;
                Console.Clear();

                if (c.choice == 'r')
                {
                    Console.WriteLine("You have ended the violence by not fighting");
                    Console.WriteLine("\nFinal Statistics");
                    Console.WriteLine("\nStrength: " + c.strength);
                    Console.WriteLine("Health:   " + c.health);
                    Console.WriteLine("Damage:   " + c.damage);
                    Console.WriteLine("\nYour total score is 0");
                    Console.ReadKey();
                }
                else if (c.choice == 'h')
                {
                    Console.WriteLine("Hero: " + name);
                    Console.WriteLine("\nStrength: " + c.strength);
                    Console.WriteLine("Health:   " + c.health);
                    Console.WriteLine("Damage:   " + c.damage);

                    Random rand1 = new Random();
                    string[] monsterList = new string[] { "Zombie", "Skeleton", "Viper", "TheClown" };
                    var randomMonster = monsterList[rand1.Next(0, 3)]; // .Next(0, 3) or .Next(0, monsterList.Length)

                    Console.WriteLine("\nVillain: {0}", randomMonster);
                    c.RandomVillain();
                    Console.WriteLine("\n-----------------------------------------------");

                    Battle b = new Battle();
                    b.battle(c.strength, c.health, c.damage, c.vstrength, c.vhealth, c.vdamage, b.hPoints, b.vPoints, randomMonster);

                    while (true)
                    {
                        Console.Write("Do you want to continue? ");
                        answer = Console.ReadKey().KeyChar;

                        if (answer == 'y')
                        {
                            Console.Clear();
                            Loop(randomMonster);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input! Try again");
                }
            }

            catch
            {
                Console.WriteLine("Wrong input!");
            }

        }

        public static void Loop(string randomMonster)  //method/function for looping if the player wants to continue
        {
            Character c2 = new Character();  //instance/object for Class Character. Mike told me this is not safe but it works well with my Program

            Console.WriteLine("Hero: " + name);
            c2.RandomNumbers();  //method/function called from Class Character
            Thread.Sleep(100);  //avoid duplication of random number since c2.RandomNumbes() and c2.RandomVillain() are written close to each other.

            Console.WriteLine("\nVillain: {0}", randomMonster);
            c2.RandomVillain();  //method/function called from Class Character
            Console.WriteLine("\n-----------------------------------------------");

            Battle b = new Battle();  //instance/object for Class Battle. Mike told me this is not safe but it works well with my Program
            b.battle(c2.strength, c2.health, c2.damage, c2.vstrength, c2.vhealth, c2.vdamage, b.hPoints, b.vPoints, randomMonster); /*to access variables
                                                            from other Class (Character and Battle*/
        }
    }
}

/*Make a list of rounds/tries at the end of the game when the user decides to quit". I don't have it in this Program. You can use this variable
 public List<Round> rounds = new List<Round>();*/
