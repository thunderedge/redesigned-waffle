using System;
using System.Diagnostics;
using System.Threading;

namespace U2BA3 
{
  class Simple 
  {
      static int Mul2(int a, int b) 
      {
          return a * b;
      }
      
      static int Mul3(int a, int b, int c)
      {
          return Mul2(a, (b, c));
      }
      
      static int Add2(int a, int b)
      {
          return a + b;
      }
      
      static int Add3(int a, int b, int c)
      {
          return Add2(a, (b, c));
      }
    
      static int Quadratic(int x, int a, int b, int c)
      {
          int q1 = Mul3(x, x, a);
          int q2 = Mul2(x, b);
          int q3 = c;
          return Add3(q1, q2, q3);
      }    

      static void Main(string[] args)
      {
          int y1 = Quadratic(1, 4, 3, 2);
          int y2 = Quadratic(2, 4, 3, 2);
          int y3 = Quadratic(3, 4, 3, 2);
          y1=y1+y2+y3;
      }
  }
}
