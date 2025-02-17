using System;
using System.Diagnostics.Contracts;
//scroll down towards the bottom from class notes
public class MathAssignment : Assignment
{
    //make sure to have a getter
    //remember getter returns the value of the private field public string ----> return _privateName
    //remember setter sets the value of the private field public void (string value) ---> _privateName = privateName
    private string _textBookSection = "";
    private string _problems = "";

    public string GetTextBookSection()
    {
        return _textBookSection;
    }

    public void SetTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetHomeWorkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }

}
//Another Way to Write the Assignment...
// public class MathAssignment : Assignment
// {
//     private string _textbookSection;
//     private string _problems;

//     // Notice the syntax here that the MathAssignment constructor has 4 parameters and then
//     // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
//     public MathAssignment(string studentName, string topic, string textbookSection, string problems)
//         : base(studentName, topic)
//     {
//         // Here we set the MathAssignment specific variables
//         _textbookSection = textbookSection;
//         _problems = problems;
//     }

//     public string GetHomeworkList()
//     {
//         return $"Section {_textbookSection} Problems {_problems}";
//     }
// }