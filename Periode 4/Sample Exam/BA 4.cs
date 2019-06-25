using System;

namespace Dev4ExamsSBA4
{
  class Program
  {
    public static void Main(string[] args)
    {
      Turtle donatello = new Turtle(1);
      donatello.Up();
      donatello.Right();
      donatello.Up();
      donatello.Left();
      donatello.Down();
      donatello.Down();
      donatello.Right();
      donatello.Left();
    }
  }

  public interface IMoveablePlayer
  {
    void Up();
    void Down();
    void Left();
    void Right();
  }

  public class Turtle : IMoveablePlayer
  {
    public int x;
    public int y;
    public int stepSize;

    public Turtle(int stepSize)
    {
      this.stepSize = stepSize;
    }

    public void Up(){
      this.y = y + 1;
    }
    
    public void Down(){
      this.y = y - 1;
    }
    
    public void Left(){
      this.x = x - 1;
    }
    
    public void Right(){
      this.x = x + 1;
    }
