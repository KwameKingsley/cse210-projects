using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1; // Indicates no end verse
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        return _endVerse == -1
            ? $"{_book} {_chapter}:{_verse}"
            : $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}