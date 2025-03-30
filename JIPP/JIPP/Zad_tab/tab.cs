using System;
using System.Collections.Generic;

namespace JIPP.Zad_tab
{
    internal class tab
    {
        public static void Run()
        {
            // ZAD 1
            string[] colors = { "Niebieski", "Zielony", "Żółty", "Czerwony" };

            Console.WriteLine($"Mój pierwszy kolor to: {colors[0]}");
            Console.WriteLine($"Mój ostatni kolor to: {colors[colors.Length - 1]}");

            // ZAD 2
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("\nPętla for:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Liczba: {numbers[i]}");
            }

            Console.WriteLine("\nPętla foreach:");
            foreach (int number in numbers)
            {
                Console.WriteLine($"Liczba: {number}");
            }

            Console.WriteLine("\nPętla while:");
            int index = 0;
            while (index < numbers.Length)
            {
                Console.WriteLine($"Liczba: {numbers[index]}");
                index++;
            }

            // ZAD 3
            List<string> fruits = new List<string> { "Pomidor", "Jabłko", "Marchewka", "Banana" };

            Console.WriteLine("\nLista owoców: " + string.Join(", ", fruits));

            // Usuwanie elementów
            fruits.RemoveAt(0); // Usuwa pierwszy element
            fruits.RemoveAt(fruits.Count - 1); // Usuwa ostatni element

            Console.WriteLine("Lista po usunięciu pierwszego i ostatniego elementu: " + string.Join(", ", fruits));
        }
    }
}
