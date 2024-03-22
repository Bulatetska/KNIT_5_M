using System;

class Program { 
    static void Main(string[] args) {
        var program = new Program();
        program.task();
    }

    void task() {
        header("Task 2");
        Console.WriteLine("Введіть натуральне число (менше 100):");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number < 100 && number > 0)
        {
            int count = 0;
            int sum = 0;

            foreach (char digit in input)
            {
                sum += digit - '0';
                count++;
            }

            Console.WriteLine($"Кількість цифр у числі: {count}");
            Console.WriteLine($"Сума цифр у числі: {sum}");
        }
        else
        {
            Console.WriteLine("Введене значення не є натуральним числом менше 100.");
        }
    }

    private void header(string title) {
        System.Console.Write("================= ");
        System.Console.Write(title);
        System.Console.Write(" =================");
        System.Console.Write("\n");
    }
}