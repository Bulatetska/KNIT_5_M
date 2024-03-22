using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string University { get; set; }

    public Student(string name, int age, string university)
    {
        Name = name;
        Age = age;
        University = university;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Ім'я: {Name}");
        Console.WriteLine($"Вік: {Age}");
        Console.WriteLine($"Університет: {University}");
    }
}

class Aspirant : Student
{
    public string ResearchTopic { get; set; }

    public Aspirant(string name, int age, string university, string researchTopic)
        : base(name, age, university) 
    {
        ResearchTopic = researchTopic;
    }

    public override void PrintInfo()
    {
        base.PrintInfo(); 
        Console.WriteLine($"Тема кандидатської роботи: {ResearchTopic}");
    }
}

class Program { 
    static void Main(string[] args) {
        var program = new Program();
        program.task();
    }

 
    void task() {
        header("Task 2");
        Student student = new Student("Іван", 20, "Київський національний університет");
        Console.WriteLine("Інформація про студента:");
        student.PrintInfo();
        Console.WriteLine();
        Aspirant aspirant = new Aspirant("Петро", 25, "Київський політехнічний інститут", "Дослідження в галузі штучного інтелекту");
        Console.WriteLine("Інформація про аспіранта:");
        aspirant.PrintInfo();
    }

    private void header(string title) {
        System.Console.Write("================= ");
        System.Console.Write(title);
        System.Console.Write(" =================");
        System.Console.Write("\n");
    }
}