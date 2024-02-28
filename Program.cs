using System;
using System.Collections.Generic;

namespace Uppgift_6_3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Välkommen! Nu kommer du kunna skriva in en bas upphöjt till något.");
        Console.WriteLine("Skriv det du önskar i respektive ordning.");
        double bas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Okej, nu kan du skriva in potensen:");
        double potens = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Svaret på " + bas + "^" + potens + " blir: " + Math.Pow(bas, potens));
    }

    static double svar(double bas, double potens)
    {
        double svar = Math.Pow(bas, potens);
        return svar;

    }
}