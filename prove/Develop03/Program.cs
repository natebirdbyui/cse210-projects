using System;

//for exceeding the requirements, I have added a big scripture library. Also I created a huge scripture reference to memorize.
public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program! \n");

        // this will begin the reference library and scripture library, the constructor will be called
        Reference reference = new Reference();
        string randomReference = reference.GetRandomScriptureReference();
        var scriptureData = reference.GetScripture(randomReference);

        string[] parts = randomReference.Split(' ');//this will split the reference into parts
        string book = string.Join(" ", parts.Take(parts.Length - 1));//this will join the parts of the book
        
        //this will create a new scripture object and the constructor will pass in the book, chapter, start verse, end verse, and text
        Scripture scripture = new Scripture(
            book,
            scriptureData.GetChapter(), 
            scriptureData.GetStartVerse(), 
            scriptureData.GetEndVerse(),
            scriptureData.GetText());
        
        Console.Clear();//this will clear the console to help stop double outputs
        scripture.DisplayScripture();//this will display the scripture

        bool _hideWord = true; //this will hide the word

        while (_hideWord)//this will loop until the user types quit
        {
            Console.WriteLine("Press enter to hide the words or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();//helps to make sure quit is ok anyway typed

            if (input == "quit")
            {
                _hideWord = false;
                Console.WriteLine("Goodbye! Keep on studying!");
            }

            else//this will hide a random word
            {
                scripture.HideRandomWord();//this will hide a random word
                Console.Clear();
                scripture.DisplayScripture();//this will display the scripture
            }
            //if all the words are hidden, the program will end and the loop will break
            if (scripture.AllWordsHidden())//this will check if all the words are hidden
            {
                Console.WriteLine("All words have been hidden. That means you've memorized it! Great job!");
                break;//breaks loop
            }
        }
    }
}