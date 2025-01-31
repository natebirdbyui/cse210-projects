using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.IO;

public class Journal
{//use Entry.cs
    public List<Entry> _entries = new List<Entry>();
    public void NewEntry() //case 1: Write
    {//Generate Prompt under Entry.cs file
        Entry userInput = new Entry();
        userInput.GenerateDate();
        userInput.GeneratePrompt();
        userInput.GetResponse();
        _entries.Add(userInput);
    }

    public void DisplayEntry() // case 2: Display
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Entry Date: {entry._date}");
            Console.WriteLine($"Journal Prompt: {entry._prompt}");
            Console.WriteLine($"Your entry: {entry._response} \n");
            
        }
    }

    public void LoadEntry(string fileName)
    {
        try//make sure to have a catch after try--such as try and except in python
        {
            if (!File.Exists(fileName))//this will help for the system not to crash
            {
                Console.WriteLine("Error: File not found");
                return;
            }
            if (!fileName.EndsWith(".csv"))//helps to make sure the file is a csv and to minimize errors
            {
                Console.WriteLine("Error: File must be a '.csv' file");
                return;
            }
            {
                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    Console.WriteLine($"Date: {date}");
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.WriteLine($"{response}\n");
                }
            }
        }
        catch
        {
            Console.WriteLine("Error: File not found");
        }
    }

    public void SaveEntry(string fileName)//make sure to save file under .csv
    {
        try
        {
            if (!fileName.EndsWith(".csv"))
            {
                fileName += ".csv"; //this will add the .csv if missing from the file name. This will help to minimize errors and save your file from crashing when trying to load
            }

            using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Entry entry in _entries)
                    {
                        outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
                    }
                }
            Console.WriteLine($"Filed saved as {fileName}");

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}