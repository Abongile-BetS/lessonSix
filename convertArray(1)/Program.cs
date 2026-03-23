using System;
using System.Collections.Generic;

// TODO: Create a Student class with:
// - Name property
// - Age property
// - Mark property
// - constructor
// - PrintSummary() method
public class Student
{
    private string name { get; set; }
    private int age { get; set; }
    private double marks { get; set; }

    public Student(string name, int age, double marks)
    {
        this.name = name;
        this.age = age;
        this.marks = marks;
    }

    public void printSummary()
    {
        Console.WriteLine($"{name} ({age}) - {marks}%");

    }
}

public class main
{
    public static void Main(String[] args)
    {
        string[] names = { "Ava", "Ben", "Chen" };
        int[] ages = { 19, 21, 20 };
        double[] marks = { 72.5, 88.0, 64.0 };

        List<Student> students = new();

        for(int i = 0; i < names.Length; i++)
        {
            students.Add(new Student(names[i], ages[i], marks[i]));
        }

        Console.WriteLine("All students:");
        foreach(var student in students)
        {
            student.printSummary();
        }

        students.RemoveAt(1);
        Console.WriteLine();
        Console.WriteLine("After removing index 1:");

        foreach(var student in students)
        {
            student.printSummary();
        }
     
    }
}
