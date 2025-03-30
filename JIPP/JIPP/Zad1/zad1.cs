using System;

class zad1
{
    public static void Run()
    {
        // Przypisanie wartości do zmiennych w jednym miejscu
        var number = 10;
        var money = 99.99f;
        var text = "Hello, C#!";
        var isLogged = true;
        var myChar = 'A';
        var price = 199.99m;

        var myAge = "Age: ";
        var wifeAge = 18;
        var result = $"{myAge}{wifeAge}";

        // Operacje na liczbach
        var a = 5;
        var b = 12;
        var (add, sub, div, mul, mod) = (a + b, a - b, a / b, a * b, a % b);

        // Operacje logiczne
        bool isTrue = true, isFalse = false, isReallyTrue = true;
        var and = isTrue && isFalse;
        var or = isTrue || isReallyTrue;
        var negative = !isFalse;

        // Łączenie stringów
        var aStr = "Ala ";
        var bStr = "ma ";
        var cStr = "kota.";
        var resultStr = $"{aStr}{bStr}{cStr}";

        // Porównanie dwóch liczb
        var n1 = 10;
        var n2 = 20;
        string comparisonResult = (n1 > n2) ? $"{n1} jest większe od {n2}" : (n1 < n2) ? $"{n2} jest większe od {n1}" : $"{n1} jest równe {n2}";
        Console.WriteLine(comparisonResult);

        // Pętla for
        for (var i = 0; i < 10; i++) Console.WriteLine("C#");

        // Pętla while
        var count = 0;
        while (count < 10)
        {
            Console.WriteLine("C#");
            count++;
        }

        // Pętla z warunkiem parzystości
        for (var i = 0; i <= n1; i++)
            Console.WriteLine($"{i} - {(i % 2 == 0 ? "Parzysta" : "Nieparzysta")}");

        // Drukowanie gwiazdek
        for (var i = 1; i <= 5; i++)
        {
            Console.WriteLine(new string('*', i));
        }

        // Wydrukowanie wartości
        PrintValues(number, money, text, isLogged, myChar, price, result, add, sub, div, mul, mod, and, or, negative, resultStr);
    }

    static void PrintValues(params object[] values)
    {
        foreach (var value in values)
        {
            Console.WriteLine(value);
        }
    }
}
