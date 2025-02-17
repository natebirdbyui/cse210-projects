using System;
using System.Security.Cryptography.X509Certificates;
//scroll down towards the bottom from class notes
class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Samuel Bennett");
        assignment1.SetTopic("Multiplication");
        
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine("");

        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetStudentName("Roberto Rodriguez");
        assignment2.SetTopic("Fractions");
        assignment2.SetTextBookSection("7.3");
        assignment2.SetProblems("8-19");
        
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeWorkList());
        Console.WriteLine("");

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetStudentName("Mary Waters");
        assignment3.SetTopic("European History");
        assignment3.SetTitle("The Causes of World War II");

        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}

//Another way to write the assignment
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create a base "Assignment" object
//         Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
//         Console.WriteLine(a1.GetSummary());

//         // Now create the derived class assignments
//         MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
//         Console.WriteLine(a2.GetSummary());
//         Console.WriteLine(a2.GetHomeworkList());

//         WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
//         Console.WriteLine(a3.GetSummary());
//         Console.WriteLine(a3.GetWritingInformation());
//     }
// }