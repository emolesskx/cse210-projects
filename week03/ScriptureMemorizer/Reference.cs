// Reference.cs
using System;

class Reference
{
    private string _book;
    private int _startChapter;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book;
        _startChapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        return _endVerse.HasValue 
            ? $"{_book} {_startChapter}:{_startVerse}-{_endVerse}"
            : $"{_book} {_startChapter}:{_startVerse}";
    }
}