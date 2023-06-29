using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę wierszy:");
        int wiersze = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę kolumn:");
        int kolumny = int.Parse(Console.ReadLine());

        int[,] tablica = new int[wiersze, kolumny];

        int wartosc = 1;
        for (int i = 0; i < wiersze; i++)
        {
            for (int j = 0; j < kolumny; j++)
            {
                tablica[i, j] = wartosc;
                wartosc++;
            }
        }

        for (int i = 0; i < wiersze; i++)
        {
            for (int j = 0; j < kolumny; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

