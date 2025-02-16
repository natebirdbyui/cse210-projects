using System;

public class Word
{
    private string _text;//this will hold the text of the word
    private bool _hideWord;//this will hide the word

    public Word(string text)//this will create a new word object and pass in the text
    {
        _text = text;
        _hideWord = false;
    }
    public string GetText()//this will get the text
    {
        return _text;
    }
    public bool GetIsHidden()//this will get if the word is hidden
    {
        return _hideWord;
    }
    public void HideWord()//this will hide the word
    {
        _hideWord = true; //this will hide the word and calls the setter
    }

    public bool IsHidden()//this will check if the word is hidden
    {
        return _hideWord;
    }

    
    public void DisplayScripture()
    {
        Console.Write(_hideWord ? new string('_', _text.Length) + " " : _text + " ");//this will display the word if it is not hidden
        // ? is a conditional operator that will check if the word is hidden
    }
}