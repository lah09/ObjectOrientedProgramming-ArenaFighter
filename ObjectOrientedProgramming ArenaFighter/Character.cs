using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter
{
    public class Character
    {
        public char choice;
        public static string name; /*made this static so the name input in class Program
                                     can be displayed in classes*/
        public static string Name
        {  /*here Andreas, Mike told me to simply use, for example 
                                       "public static string Name { get; set; }" for the rest
                                       of the variables with ({get; set;) (this is actually Property of C#.
                                       I won't do alteration because it can cause error for me Program*/
            get { return name; }
            set { name = value; }
        }

        public int strength;           //same here
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int health;              //same here
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int damage;              //same here
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int vstrength;           //same here
        public int Vstrength
        {
            get { return vstrength; }
            set { vstrength = value; }
        }

        public int vhealth;             //same here
        public int Vhealth
        {
            get { return vhealth; }
            set { vhealth = value; }
        }

        public int vdamage;             //same here
        public int Vdamage
        {
            get { return vdamage; }
            set { vdamage = value; }
        }

        public void RandomNumbers()  //this is method or function to get random numbers for the variables strength, health, damage (for main player/hero)
        {
            Random r = new Random();
            strength = r.Next(1, 11);
            health = r.Next(1, 11);
            damage = r.Next(1, 11);

            Console.WriteLine("\nStrength: " + strength);
            Console.WriteLine("Health:   " + health);
            Console.WriteLine("Damage:   " + damage);
        }

        public void RandomVillain() //this is method or function to get random numbers for the variables vstrength, vhealth, vdamage (for villain/opponent)
        {
            Random r = new Random();
            vstrength = r.Next(1, 11);
            vhealth = r.Next(1, 11);
            vdamage = r.Next(1, 11);
            Console.WriteLine("\nStrength: " + vstrength);
            Console.WriteLine("Health:   " + vhealth);
            Console.WriteLine("Damage:   " + vdamage);
        }
    }
}