using System;
using System.Collections.Generic;
using System.Linq;

//it may be easier to make another file that has the scripture on them such as ScriptureKey.cs
public class Scripture
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _text;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)//this will create a new scripture object and constructor will pass
    // in the book, chapter, start verse, end verse, and text
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse > 0 ? endVerse : startVerse;//this will check if the end verse is greater than 0 and if not it will set it to the start verse
        _text = text;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();//this will split the text into words and then create a new word object for each word
    }
    
    public string GetBook()//this will get the book
    {
        return _book;
    }
    public void SetBook(string book)//this will set the book
    {
        _book = book;
    }
    public int GetChapter()//this will get the chapter
    {
        return _chapter;
    }
    public void SetChapter(int chapter)//this will set the chapter
    {
        _chapter = chapter;
    }
    public int GetStartVerse()//this will get the start verse
    {
        return _startVerse;
    }
    public int GetEndVerse()//this will get the end verse
    {
        return _endVerse;
    }
    public void SetEndVerse(int endVerse)//this will set the end verse
    {
        _endVerse = endVerse > 0 ? endVerse : _startVerse; //this will check if the end verse is greater than 0 and if not it will set it to the start verse
    }
    
    public string GetText()//this will get the text
    {
        return _text;
    }
    public void SetText(string newText)//this will set the text
    {
        _text = newText;
    }
    public void DisplayScripture()//this will display the scripture
    {
        Console.Clear();//this will clear the console to help stop double outputs

        string verseReference = _startVerse == _endVerse ? $"{_startVerse}" : $"{_startVerse}-{_endVerse}";//this checks if the start verse is the same as the end verse and if it needs to have X:x-y
        
        Console.Write($"{_book} {_chapter}:{verseReference} ");
        foreach (var word in _words)
        {
            word.DisplayScripture();
        }
        Console.WriteLine(); // New line after displaying scripture
    }
    public void HideRandomWord()//this will hide a random word
    {
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();//this will get all the words that are hidden
        if (visibleWords.Count > 0)
        {
            int wordsToHide = Math.Max(1, visibleWords.Count / 5); // Hide about 20% of words each time

            for (int i = 0; i < wordsToHide; i++)//this will loop through the words to hide
            {
                if (visibleWords.Count == 0)
                    break; // Stop if all words are already hidden

                int index = _random.Next(visibleWords.Count); // Pick a random word
                visibleWords[index].HideWord();//this will hide the word
                visibleWords.RemoveAt(index); // Remove from list to avoid re-selecting
            }
        }
    }
    public bool AllWordsHidden()//this will check if all the words are hidden
    {
        return _words.All(word => word.IsHidden());//this will check if all the words are hidden
    }

}