using System;
using System.Collections.Generic;
using System.Linq;

class Program { 
    static void Main(string[] args) {
        var program = new Program();
        program.task();
    }

    struct Student
    {
        public string LastName;
        public int StudentID;
        public double InformaticsGrade;
        public double MathGrade;
        public double AlgebraGrade;
        public double AverageGrade;
    }

    void task() {
        header("Task 3");
        Student[] students = new Student[10];

        // Заповнюємо масив даними про студентів
        students[0] = new Student { LastName = "Макута", StudentID = 12345, InformaticsGrade = 95, MathGrade = 85, AlgebraGrade = 90 };
        students[1] = new Student { LastName = "Бонюк", StudentID = 23456, InformaticsGrade = 80, MathGrade = 75, AlgebraGrade = 70 };
        students[2] = new Student { LastName = "Литвинчук", StudentID = 34567, InformaticsGrade = 88, MathGrade = 92, AlgebraGrade = 85 };
        students[3] = new Student { LastName = "Булатецька", StudentID = 45678, InformaticsGrade = 75, MathGrade = 83, AlgebraGrade = 78 };
        students[4] = new Student { LastName = "Юзва", StudentID = 56789, InformaticsGrade = 90, MathGrade = 87, AlgebraGrade = 92 };
        students[5] = new Student { LastName = "Павленко", StudentID = 67890, InformaticsGrade = 85, MathGrade = 80, AlgebraGrade = 75 };
        students[6] = new Student { LastName = "Скорук", StudentID = 78901, InformaticsGrade = 95, MathGrade = 88, AlgebraGrade = 90 };
        students[7] = new Student { LastName = "Пелех", StudentID = 89012, InformaticsGrade = 78, MathGrade = 82, AlgebraGrade = 85 };
        students[8] = new Student { LastName = "Федчун", StudentID = 90123, InformaticsGrade = 82, MathGrade = 90, AlgebraGrade = 88 };
        students[9] = new Student { LastName = "Пастушок", StudentID = 12345, InformaticsGrade = 88, MathGrade = 85, AlgebraGrade = 80 };

        for (var i = 0;  i < 10;i++)
        {
            students[i].AverageGrade = (students[i].InformaticsGrade + students[i].MathGrade + students[i].AlgebraGrade) / 3.0;
        }

        Array.Sort(students, (x, y) => y.AverageGrade.CompareTo(x.AverageGrade));

        Console.WriteLine("Список студентів за середньою оцінкою:");
        foreach (var student in students)
        {
            Console.WriteLine($"Прізвище: {student.LastName}, Номер заліковки: {student.StudentID}, Середня оцінка: {student.AverageGrade}");
        }
    }

    private void header(string title) {
        System.Console.Write("================= ");
        System.Console.Write(title);
        System.Console.Write(" =================");
        System.Console.Write("\n");
    }
}