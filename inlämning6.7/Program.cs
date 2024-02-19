using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        Primtal(x);
    }
    static void Primtal(int x)
    {
        int gånger = 0;
        for (int i = 1; i < x; i++)
        {
            if(x%i == 0)
            {
                gånger++;
            }
        }
        if (gånger > 2|| x==4)
        {
            Console.WriteLine(x+" är INTE ett primtal");
        }
        else
        {
            Console.WriteLine(x+" är ett primtal");
        }
    }
}