using System;

namespace Triangle2
{
    class Program
    {
       static void Main(string[] args)
        {
           
           for (int i=1; i<=5; i++)
           {
               int j=1;
               while (j<=i)

               {
                   Console.Write("*");
                    j++;
               }
                Console.WriteLine("\n");
           }
        }
    }
}