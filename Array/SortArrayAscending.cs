using System;

public class SortArrayAscending{
    public static async void Main(String[] args){
        int i,j, temp,n;
        int[] arr=new int[15];

        Console.WriteLine("Give Array Number");
        n=int.Parse(Console.ReadLine());

        Console.WriteLine("enter the array element");
        for(i=0;i <n;i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }

        for(i=0;i <n;i++)
        {
            for(j=i+1;j<n;j++)
            {
                if(arr[i]>arr[j])
                {
                    temp=arr[i];
                    arr[i]=arr[j];
                    arr[j] =temp;
                }
            }
        }
        Console.WriteLine("After ascending numbers");
        for(i=0;i<n;i++)
        {
            Console.WriteLine(arr[i]);
        }
        
    }
}