using System;

public class Employee
{
    public string Name { get; set; }
    public string Title { get; set; }
    public decimal BaseSalary { get; set; }

    public Employee(string name, string title, decimal baseSalary)
    {
        Name = name;
        Title = title;
        BaseSalary = baseSalary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Base Salary: {BaseSalary:C}");
    }
}

public class Manager : Employee
{
    public decimal Bonus { get; set; }

    public Manager(string name, string title, decimal baseSalary, decimal bonus)
        : base(name, title, baseSalary)
    {
        Bonus = bonus;
    }

    public void CalculateBonus(decimal performanceScore)
    {
        Bonus = BaseSalary * (performanceScore / 100);
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Bonus: {Bonus:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager("John Doe", "Senior Manager", 60000, 5000);
        manager.CalculateBonus(85);

        Console.WriteLine("Employee Details:");
        manager.DisplayDetails();
    }
}
