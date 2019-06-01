using System;
using System.Diagnostics;
using System.Threading;

namespace U0BA9
{
    class Test
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(2.0, 1.0);
            Point p2 = new Point(6.0, 4.0);
            Line line1 = new Line(p1, p2);
            double length = line1.Distance();
            Canvas myCanvas = new Canvas(3);
            myCanvas.AddLine(line1);
            int numberOfLines = myCanvas.numLines;
            myCanvas.Undo();
            numberOfLines = myCanvas.numLines;
            myCanvas.Undo();
            numberOfLines = myCanvas.numLines;
            myCanvas.AddLine(line1);
            Point p3 = new Point(0.0, 0.0);
            Point p4 = new Point(1.0, 1.0);
            Line line2 = new Line(p3, p4);
            myCanvas.AddLine(line2);
            myCanvas.AddLine(line1);
            numberOfLines = myCanvas.numLines;
            myCanvas.AddLine(line2);
            numberOfLines = myCanvas.numLines;
        }
    }

  // Create a class named Point. 
  // The class should have two fields, x and y (doubles)
  // The constructor should take in two doubles and assign them to each of the fields

  // Create a class named Line. 
  // The class should have one field, points (an array of type Point)
  // The constructor should take two Points and store them in the Points array
  // There should be a method called Distance that calculates the distance between 
  // the two points (so the Length of the line). The formula is 
  // sqrt((x2-x1)^2 + (y2-y1)^2) (See https://www.wikihow.com/Use-Distance-Formula-to-Find-the-Length-of-a-Line)
  // You will need to use Math.Sqrt() to calculate the square root,
  // and Math.Pow() to calculate the power of 2.

  // Create a class named Canvas. 
  // The class should have two fields, lines (an array of type Line) and numLines (an int)
  // The constructor should take an int size and set the size of the array to this int
  // The constructor should also set numLines to 0
  // There should be a method called AddLine that takes in a Line. If there is enough space in the
  // lines array then this will be added, otherwise nothing will be added (hint: numLines will be useful)
  // There should be a method called Undo that sets the last line added in the array to null, but only 
  // if there is a line in the array , otherwise nothing will happen (hint: numLines will be useful)

}

