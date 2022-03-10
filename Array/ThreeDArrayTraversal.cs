using System;

  public class ThreeDArrayTraversal
{
     static void Main(String[] args)
  {
    int[,,] b={{{10,20},{30,40},{50,60}}}; //array creation and initialization
   
    //Traversing the array
    for(int i=0;i<b.Length;i++)
      {
          //for(int j=0;j<b[j].Length;j++)
          for(int j=0;j<b.GetLength(1);j++)
          {
        //for(int k=0;k<b[i,j].Length;k++)
          for(int k=0;k<b.GetLength(2);j++)

            {
                Console.WriteLine(b[i,j,k]+" ");

            }
          }
      }
  }
}
