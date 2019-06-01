﻿using System;
using System.Diagnostics;
using System.Threading;

namespace U0BA2
{
    class Test
    {
        public static void Main(string[] args)
        {
            Cat c1 = new Cat("Whiskers", "Meow", 1.5);
            string s1 = c1.MakeSound();
            c1.Feed();
            double w1 = c1.weight;

            Cat c2 = new Cat("Mr Fluffy", "Mauw", 1.6);
            string s2 = c2.MakeSound();
            c2.Feed();
            double w2 = c2.weight;
        }
    }

    class Cat
    {
        public string name;
        public string sound;
        public double weight;

        public Cat(string name, string sound, double weight)
        {
            this.name = name;
            this.sound = sound;
            this.weight = weight;
        }

        //Create a public MakeSound method which returns a string in the form of "[name] says [sound]"
        public string MakeSound()
        {
            return this.name + " says " + this.sound;
        }

        //Create a public Feed method which increments the weight by 0.5
        public void Feed()
        {
            this.weight += 0.5;
        }
    }
}
