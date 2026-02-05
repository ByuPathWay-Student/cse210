using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Timmy Wood", "Division");
        MathAssignment mathAssignment = new MathAssignment("Duncan Warner", "Multiplication", "9", "2-5");
        WritingAssignment writingAssignment = new WritingAssignment("Lesli Wendell", "English", "My short story");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();
        
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}