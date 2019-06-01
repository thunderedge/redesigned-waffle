using System;
using System.Diagnostics;
using System.Threading;

namespace U0BA6
{
    class Test
    {
        public static void Main(string[] args)
        {
            Player p1 = new Player("John Snow", 30);
            Player p2 = new Player("Night King", 60);

            string winner = null;
            while (winner == null)
            {
                p1.TakeDamage(p2.damage);
                p2.TakeDamage(p1.damage);

                if (p1.healthPoints < 0 && p2.healthPoints < 0)
                {
                    winner = "It is a draw";
                }
                else if (p1.healthPoints < 0)
                {
                    winner = p2.name + " wins";
                }
                else if (p2.healthPoints < 0)
                {
                    winner = p1.name + " wins";
                }
            }
        }
    }

    // Create a class named Player. 
    // The class should have three fields, name (string) healthPoints and damage (both ints)
    // The constructor should take in a string name and an int damage and assign them to each of the fields
    // The constructor should also set the healthPoints to 100
    // There should be one method called TakeDamage that takes in the amount of damage to apply (int) 
    // and takes that amount of damage away from the healthPoints  

    class Player
    {
        public string name;
        public int healthPoints;
        public int damage;

        public Player(string name, int damage)
        {
            this.name = name;
            this.healthPoints = 100;
            this.damage = damage;
        }

        public void TakeDamage(int amount)
        {
            this.healthPoints -= amount;
        }
    }
}

