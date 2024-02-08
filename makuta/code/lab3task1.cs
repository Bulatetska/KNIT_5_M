using System;

class Person
{
    private string name;
    private int age;
    private string gender;
    private string phoneNumber;

    public Person(string name, int age, string gender, string phoneNumber)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.phoneNumber = phoneNumber;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public void SetGender(string gender)
    {
        this.gender = gender;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public void Print()
    {
        Console.WriteLine($"Ім'я: {name}");
        Console.WriteLine($"Вік: {age}");
        Console.WriteLine($"Стать: {gender}");
        Console.WriteLine($"Телефонний номер: {phoneNumber}");
    }
}

class Program { 
    static void Main(string[] args) {
        var program = new Program();
        program.task();
    }

 
    void task() {
        header("Task 1");
        Person person = new Person("Іван", 25, "чоловік", "123-45-67");
        Console.WriteLine("Інформація про особу:");
        person.Print();
        person.SetAge(30);
        person.SetPhoneNumber("987-65-43");
        Console.WriteLine("\nОновлена інформація про особу:");
        person.Print();
    }

    private void header(string title) {
        System.Console.Write("================= ");
        System.Console.Write(title);
        System.Console.Write(" =================");
        System.Console.Write("\n");
    }
}