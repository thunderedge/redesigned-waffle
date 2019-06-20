using System;
using System.Diagnostics;
using System.Threading;

namespace Tests
{
  public class Dataset 
  {
    public int[][] elems;

    public Dataset(int[][] elems)
    {
      this.elems = elems;
    }

    public int Sum()
    {
      int sum = 0;
      for (int i = 0; i < this.elems.Length; i++)
      {
        for (int j = 0; j < this.elems[i].Length; j++)
        {
          sum = sum + this.elems[i][j];
        }
      }
      return sum;
    }

    public int SumDiagonal()
    {
      int sum = 0;
      for (int i = 0; i < this.elems.Length; i++)
      {
        for (int j = 0; j < this.elems[i].Length; j++)
        {
          if (i == j)
          {
            sum = sum + this.elems[i][j];
          }
        }
      }
      return sum;
    }

    public Dataset MakeNewDataset(int increment)
    {
      int[][] arr = new int[this.elems.Length][];
      for (int i = 0; i < arr.Length; i++)
      {
        arr[i] = new int[this.elems[i].Length];
        for (int j = 0; j < arr[i].Length; j++)
        {
          arr[i][j] = this.elems[i][j] + increment;
        }
      }
      return new Dataset(arr);
    }

    static void Main(string[] args)
    {
      int[][] data = new int[4][]  ;
      for (int i = 0; i < data.Length; i++)
      {
        data[i] = new int[4];
        for (int j = 0; j < data[i].Length; j++)
        {
          data[i][j] = i + 1;
        }
      }
      Dataset d1 = new Dataset(data);
      int ans1 = d1.Sum();

      Dataset d2 = d1.MakeNewDataset(1);
      int ans2 = d2.SumDiagonal();
    }    
  }
}
