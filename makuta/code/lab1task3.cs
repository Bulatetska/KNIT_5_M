using System;

class Program { 
    static void Main(string[] args) {
        var program = new Program();
        program.task();
    }

    void task() {
        header("Task 3");
        Console.WriteLine("Введіть число:");
        string input = Console.ReadLine();
        string reversedNumber = ReverseNumber(input);
        Console.WriteLine($"Число, перевернуте навпаки: {reversedNumber}");
    }

    string ReverseNumber(string number)
    {
        char[] charArray = number.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    private void header(string title) {
        System.Console.Write("================= ");
        System.Console.Write(title);
        System.Console.Write(" =================");
        System.Console.Write("\n");
    }
}