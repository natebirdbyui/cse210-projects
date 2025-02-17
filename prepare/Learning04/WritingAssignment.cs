using System;
using System.Runtime.CompilerServices;
//scroll down towards the bottom from class notes
public class WritingAssignment : Assignment
{
     //make sure to have a getter
    //remember getter returns the value of the private field public string ----> return _privateName
    //remember setter sets the value of the private field public void (string value) ---> _privateName = privateName
    private string _title = "";

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }

}

//Another Way to write the assignment
// public class WritingAssignment : Assignment
// {
//     private string _title;

//     // Notice the syntax here that the WritingAssignment constructor has 3 parameters and then
//     // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
//     public WritingAssignment(string studentName, string topic, string title)
//         : base(studentName, topic)
//     {
//         // Here we set any variables specific to the WritingAssignment class
//         _title = title;
//     }

//     public string GetWritingInformation()
//     {
//         // Notice that we are calling the getter here because _studentName is private in the base class
//         string studentName = GetStudentName();

//         return $"{_title} by {studentName}";
//     }
// }