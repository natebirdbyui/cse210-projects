using System;
//scroll down towards the bottom from class notes
public class Assignment
{
    protected string _studentName = "";
    private string _topic = "";

    //make sure to have a getter
    //remember getter returns the value of the private field public string
    //remember setter sets the value of the private field public void (string value)
    
    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}

// //Another way to write the assignment
// public class Assignment
// {
//     private string _studentName;
//     private string _topic;

//     public Assignment(string studentName, string topic)
//     {
//         _studentName = studentName;
//         _topic = topic;
//     }

// We will provide Getters for our private member variables so they can be accessed
// later both outside the class as well is in derived classes.
// public string GetStudentName()
// {
//     return _studentName;
// }

// public string GetTopic()
// {
//     return _topic;
// }

// public string GetSummary()
// {
//     return _studentName + " - " + _topic;
// }
