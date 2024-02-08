using System;
using System.Collections.Generic;
using System.Linq;

class Program { 
    static void Main(string[] args) {
        var program = new Program();
        program.task();
    }

    void task() {
        header("Task 2");
        int[] array = { 2, 4, 6, 8, 3, 5, 7, 9, 10 };
        int minOddNumber = FindMinOddNumber(array);
        Console.WriteLine($"Найменше непарне число у масиві: {minOddNumber}");
    }

    int FindMinOddNumber(int[] array)
    {
        int minOdd = int.MaxValue;
        foreach (int num in array)
        {
            if (num % 2 != 0 && num < minOdd)
            {
                minOdd = num;
            }
        }
        if (minOdd == int.MaxValue)
        {
            Console.WriteLine("У масиві немає непарних чисел.");
            Environment.Exit(1);
        }
        return minOdd;
    }

    private void header(string title) {
        System.Console.Write("================= ");
        System.Console.Write(title);
        System.Console.Write(" =================");
        System.Console.Write("\n");
    }
}