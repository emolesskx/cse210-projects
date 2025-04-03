// Scripture.cs
using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference);
        Console.WriteLine(string.Join(" ", _words));
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (!visibleWords.Any()) return;
        
        for (int i = 0; i < count && visibleWords.Any(); i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public void RevealRandomWord()
    {
        Random rand = new Random();
        var hiddenWords = _words.Where(w => w.IsHidden()).ToList();
        if (!hiddenWords.Any()) return;
        
        int index = rand.Next(hiddenWords.Count);
        hiddenWords[index].Reveal();
    }

    public bool IsFullyHidden() => _words.All(w => w.IsHidden());
}