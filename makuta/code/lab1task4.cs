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
        int sum = CalculateDigitSum(input);
        Console.WriteLine($"Сума цифр числа {input}: {sum}");
    }

    int CalculateDigitSum(string number)
    {
        int sum = 0;
        foreach (char digit in number)
        {
            if (char.IsDigit(digit))
            {
                sum += (int)char.GetNumericValue(digit);
            }
        }
        return sum;
    }

    private void header(string title) {
        System.Console.Write("================= ");
        System.Console.Write(title);
        System.Console.Write(" =================");
        System.Console.Write("\n");
    }
}