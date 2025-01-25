using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplay()));
        return $"{_reference.ToString()} - {scriptureText}";
    }

    public bool HideRandomWords()
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0) return false;

        var random = new Random();
        var wordToHide = visibleWords[random.Next(visibleWords.Count)];
        wordToHide.Hide();

        return true;
    }
}