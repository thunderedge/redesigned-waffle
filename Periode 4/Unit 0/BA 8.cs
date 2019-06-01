using System;
using System.Diagnostics;
using System.Threading;

namespace U0BA8
{
    class Test
    {

        public static void Main(string[] args)
        {
            Turtle leonardo = new Turtle();
            leonardo.Pen(true);
            leonardo.Right(10);
            leonardo.Up(10);
            leonardo.Left(5);
            leonardo.Down(4);
            int xPos = leonardo.position.x;
            int yPos = leonardo.position.y;
        }
    }


    // Create a class named Position. 
    // The class should have two fields, x and y (ints)
    // The constructor should take in 2 ints and assign them to each of the fields


    // Create a class named Turtle. 
    // The class should have two fields, position (of type Position) and penOn (bool)
    // The constructor should not take in anything but should set the position to 0,0
    // The constructor should also set penOn to false
    // There should be a method called Right that takes in an int and increases x by this value 
    // There should be a method called Left that takes in an int and decreases x by this value 
    // There should be a method called Up that takes in an int and increases y by this value 
    // There should be a method called Down that takes in an int and decreases y by this value 
    // There should be a method called Pen that takes in a bool and sets penOn to this value 

}

