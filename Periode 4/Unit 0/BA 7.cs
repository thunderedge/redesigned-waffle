using System;
using System.Diagnostics;
using System.Threading;

namespace U0BA7
{

  class Test
  {

    public static void Main(string[] args)
    {
            Car c1 = new Car("Toyota", "Yaris");
            Car c2 = new Car("Ferrari", "458 Italia Coupe");
            c1.SpeedUp(60);
            c1.SlowDown(5);
            c2.SpeedUp(100);
            c2.SlowDown(10);

            string s1 = "The " + c1.make + " " + c1.model + " is going " + c1.speed + "km/hr. It is ";
            s1 += c1.IsSpeeding(80) ? "speeding" : "not speeding";
            string s2 = "The " + c2.make + " " + c2.model + " is going " + c2.speed + "km/hr. It is ";
            s2 += c2.IsSpeeding(80) ? "speeding" : "not speeding";
    }
  }

    // Create a class named Car. 
    // The class should have three fields, make, model (strings) and speed (int)
    // The constructor should take in strings make and model and assigns them to each of the fields
    // The constructor should also set the speed to 0
    // There should be a method called SpeedUp that takes in an int and increases the speed by this value 
    // There should be a method called SlowDown that takes in an int and decreases the speed by this value 
    // There should be a method called IsSpeeding that takes in the current speed limit (int) and
    // returns true if the speed is greater than that speed limit and false otherwise 

    class Car
    {
        public string make;
        public string model;
        public int speed;

        public Car(string make, string model)
        {
            this.make = make;
            this.model = model;
            this.speed = 0;
        }

        public void SpeedUp(int addSpeed)
        {
            this.speed += addSpeed;
        }

        public void SlowDown(int decreaseSpeed)
        {
            this.speed -= decreaseSpeed;
        }

        public bool IsSpeeding(int speedLimit)
        {
            if (this.speed > speedLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

