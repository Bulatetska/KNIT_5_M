using System;
using System.Collections.Generic;
using System.Linq;

class Program { 
    static void Main(string[] args) {
        var program = new Program();
        program.task();
    }

    enum Season
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }

    void task() {
        header("Task 4");
        Console.WriteLine("Введіть номер місяця (від 1 до 12):");
        int month = int.Parse(Console.ReadLine());
        Season season = GetSeason(month);
        Console.WriteLine($"Місяць {month} належить до пори року: {season}");
    }

    Season GetSeason(int month)
    {
        switch (month)
        {
            case 1:
            case 2:
            case 12:
                return Season.Winter;
            case 3:
            case 4:
            case 5:
                return Season.Spring;
            case 6:
            case 7:
            case 8:
                return Season.Summer;
            case 9:
            case 10:
            case 11:
                return Season.Autumn;
            default:
                throw new ArgumentException("Некоректний номер місяця.");
        }
    }

    private void header(string title) {
        System.Console.Write("================= ");
        System.Console.Write(title);
        System.Console.Write(" =================");
        System.Console.Write("\n");
    }
}