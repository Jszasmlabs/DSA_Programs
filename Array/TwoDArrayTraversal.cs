using System;

  public class TwoDArrayTraversal
{
     static async void Main(String[] args)
  {
    int[,] b={{10,20},{30,40}}; //array creation and initialization
   
    //Traversing the array
    for(int i=0;i<b.Length;i++)
      {
        for(int j=0;j<b.GetLength(1);j++)
            {
                Console.WriteLine(b[i,j]+" ");

            }
      }
  }
}
