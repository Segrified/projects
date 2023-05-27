using System;

//An object that holds a word and checks if it is hidden
class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word) {
        _word = word;
        _isHidden = false;
    }

//displays the entry in proper format
    public void SetHidden(bool input)
    {
        _isHidden = input;
    }

//returns the _isHidden value
    public bool checkHidden() {
        return _isHidden;
    }

//returns either the word or an amount of blank spaces equal to the word length
    public string GetWordString() {
        if (_isHidden) {
            string blank = "";
            for (int i = 0; i < _word.Count(); i++) {
                blank += "_";
            }
            return blank;
        }
        else {
            return _word;
        }
    }
}