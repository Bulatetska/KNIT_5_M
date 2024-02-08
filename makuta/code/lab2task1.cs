using System;
using System.Collections.Generic;
using System.Linq;

class Program { 
    static void Main(string[] args) {
        var program = new Program();
        program.task();
    }

    void task() {
        header("Task 1");
        int[] array = { 1, 2, 3, 4, 5, 2, 3, 4, 5, 6, 7, 8, 2, 3 };
        List<int> duplicates = FindDuplicates(array);
        Console.WriteLine("Повторюються значення у масиві:");
        foreach (int value in duplicates)
        {
            Console.WriteLine(value);
        }
    }

    List<int> FindDuplicates(int[] array)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int num in array)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }

        List<int> duplicates = counts.Where(pair => pair.Value > 1).Select(pair => pair.Key).ToList();
        return duplicates;
    }

    private void header(string title) {
        System.Console.Write("================= ");
        System.Console.Write(title);
        System.Console.Write(" =================");
        System.Console.Write("\n");
    }
}