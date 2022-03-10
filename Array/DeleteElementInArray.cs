using System;

public class DeketeElementInArray{
   public static void Main(String[] args){
       int[] a= {10,40,30,80,60,20};
       int del=30;

       for(int i=0;i<a.Length;i++)
       {
           if(del==a[i])
           {
               for(int j=i; j<a.Length-1;j++)
               {
                   a[j]=a[j+1];
               }
               break;
           }
       }

       for(int i=0; i<a.Length;i++)
       {
           Console.WriteLine(a[i]+"");
       }


 }
}