using System;

//An object that holds a book, chapter, and at least one verse
class Reference
{
    private string _book;
    private int _chapter;
    private List<int> _verse = new List<int>();

//in the case one verse is given
    public Reference(string book, int chapter, int verse) {
        _book = book;
        _chapter = chapter;
        _verse.Add(verse);
    }

//in the case a verse range is given
    public Reference(string book, int chapter, int verse1, int verse2) {
        _book = book;
        _chapter = chapter;
        _verse.Add(verse1);
        _verse.Add(verse2);
    }

//returns the proper reference as a string
    public string GetReferenceString()
    {
        if (_verse.Count == 2) {
            return _book + " " + _chapter + ":" + _verse[0] + "-" + _verse[1];
        }
        else {
            return _book + " " + _chapter + ":" + _verse[0];
        }
    }
}