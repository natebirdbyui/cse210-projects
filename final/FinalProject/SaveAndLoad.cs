using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

public class SaveAndLoad
{
    public static void Save(string fileName, string data)
    {
        Console.Write("Save file as: ");
        string fileSaved = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(fileName))
        {
            file.WriteLine(data);//work more on this
        }

        //LoadingSymbol.DisplayLoadingSymbol();
        Console.WriteLine($"File saved successfully! \n Filename: {fileName}");
    }

    public static string Load(string fileName)
    {
        string [] lines = File.ReadAllLines(fileName);
        return string.Join(Environment.NewLine, lines); //combine all the lines into one string
    }
}