using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to What's my grade!");

        Console.Write("What was the percentage you received? ");
        string percentageNumber = Console.ReadLine();
        string gradeLetter = "";
        string gradeSymbol = "";
        if (float.TryParse(percentageNumber, out float grade)) //An easy way to convert string into int if needed
        {
            
            if (grade >=94)
            {
                gradeLetter = "A";
            }
            else if (grade >= 90 && grade <=93)
            {
                gradeLetter = "A";
            }
            else if (grade >= 80 && grade <= 89)
            {
                gradeLetter = "B";
            }        
            else if (grade >= 70 && grade <=79)
            {
                gradeLetter = "C";
            }    
            else if (grade >= 60 && grade <= 69)
            {
                gradeLetter = "D";
            }
            else if(grade <=59)
            {
                gradeLetter = "F";
            }

            //If you need to add a symbol to the grade
            if (gradeLetter != "A" && gradeLetter != "F")
            {
                int lastDigit = (int)grade % 10; //finds the percent's last digit
                if (lastDigit >= 7)
                {
                    gradeSymbol = "+";
                }
                else if (lastDigit <=3)
                {
                    gradeSymbol = "-";
                }
            }
            //For grade A. - or none symbol
            else if (gradeLetter == "A")
            {
                int lastDigit = (int)grade % 10;
                if (lastDigit <=3)
                {
                    gradeSymbol = "-";
                }
            }
            //Writes final grade
            Console.WriteLine($"Your grade is: {gradeLetter}{gradeSymbol}");
        }
        
        else
        {
            Console.WriteLine("Did you write a number?");
        }
    }
}