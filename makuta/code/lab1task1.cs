using System;

class Program { 
    static void Main(string[] args) {
        var program = new Program();
        program.task();
    }

    void task() {
        header("Task 1");
        Console.WriteLine("Введіть число:");
        string input = Console.ReadLine();

        // Спробуємо перетворити введене значення у ціле число
        if (int.TryParse(input, out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Число є парним.");
            }
            else
            {
                Console.WriteLine("Число є непарним.");
            }
        }
        else
        {
            Console.WriteLine("Введене значення не є числом.");
        }
    }

    private void header(string title) {
        System.Console.Write("================= ");
        System.Console.Write(title);
        System.Console.Write(" =================");
        System.Console.Write("\n");
    }
}