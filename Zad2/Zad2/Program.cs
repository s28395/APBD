﻿// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {

        int[] tab = { 1, 2, 3, 4, 5, 8, 23, 14 };
        
        Console.WriteLine("Srednia = " + srednia(tab));
        Console.WriteLine("Maximum = " + max(tab));
    }

    public static double srednia(int[] tab)
    {
        double suma = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            suma += tab[i];
        }

        return suma / tab.Length;
    }

    public static double max(int[] tab)
    {
        int max = tab[0];
        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i] > max) max = tab[i];
        }
        
        return max;
    }
}