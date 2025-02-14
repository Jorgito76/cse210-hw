using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Scripture _scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        
        while (!_scripture.AllWordsHidden())
        {
            Console.Clear();
            _scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string _input = Console.ReadLine();
            if (_input.ToLower() == "quit")
                break;
            
            _scripture.HideRandomWords(3);
        
        }
    }
}

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(string referenceText, string text)
    {
        _reference = new Reference(referenceText);
        
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }
    
    public void Display()
    {
        Console.Write(_reference._Text + " - ");
        foreach (var word in _words)
        {
            Console.Write(word._Hidden ? "____ " : word._Text + " ");
        }
    }
    
    public void HideRandomWords(int count)
    {
        Random _rand = new Random();
        var _visibleWords = _words.Where(w => !w._Hidden).ToList();
        if (_visibleWords.Count == 0) return;

        for (int i = 0; i < count; i++)
        {
            if (_visibleWords.Count == 0) break;
            var _wordToHide = _visibleWords[_rand.Next(_visibleWords.Count)];
            _wordToHide.Hide();
            _visibleWords.Remove(_wordToHide);
        }
    }
    
    public bool AllWordsHidden()
    {
        return _words.All(w => w._Hidden);
    }
}

class Reference
{
    public string _Text { get; }
    
    public Reference(string text)
    {
        _Text = text;
    }
}

class Word
{
    public string _Text { get; }
    public bool _Hidden { get; private set; }
    
    public Word(string text)
    {
        _Text = text;
        _Hidden = false;
    }
    
    public void Hide()
    {
        _Hidden = true;
    }
}