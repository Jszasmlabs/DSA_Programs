using System;

public class SearchElementInArray
{
    public static void Main(String[] args)
    {
        int[] arr=new int[55];
        int n,n1,i,flag=0;

        Console.Write("Enter the Size of Array :");
        n=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Array Element :");
        for(i=0;i<n;i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the Element to search");
        n1=int.Parse(Console.ReadLine());

        for(i=0;i<n;i++)
        {
            if(arr[i]==n1)
            {
                flag=1;
                Console.WriteLine("Number"+n1+"Found at position"+(i+1));
                break;
            }
        }

        if(flag==0)
        {
            Console.Write("Number not found in the array"+n1);
        }
    }

}