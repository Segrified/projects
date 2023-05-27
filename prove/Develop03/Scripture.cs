using System;

//An object that holds a reference and all the words in a scripture passage. Can also hide words and controls the display.
class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private int _wordcount;
    private bool _isFullyHidden;

    public Scripture(string book, int chapter, string verse, string passage) {
        _isFullyHidden = false;
        _wordcount = 0;
        string[] verses = verse.Split("-");
        Console.WriteLine(Int32.Parse(verses[0]));
        Console.WriteLine(Int32.Parse(verses[1]));
        string[] wordList = passage.Split(" ");

        //sets up the reference depending on how many verses the passage is
        if (verses.Count() == 2) {
            _reference = new Reference(book, chapter, Int32.Parse(verses[0]), Int32.Parse(verses[1]));
        }
        else {
            _reference = new Reference(book, chapter, Int32.Parse(verses[0]));
        }

        //makes a wordcount variable to keep track of which words are hidden as well as building the _words list
        for (int i = 0; i < wordList.Count(); i++) {
            _words.Add(new Word(wordList[i]));
            _wordcount += 1;
        }
    }

    //picks a random amount of words, then picks that many random words and tells them to hide
    public void HideWords() {
        Random pick = new Random();
        int amount = pick.Next(1, 4);

        //Checks if the full passage is hidden only once per enter so you can have a fully blank passage
        if (_wordcount == 0) {
            _isFullyHidden = true;
        }

        //hides the randomly selected words, but won't select words that have already been hidden
        for (int i = 0; i < amount; i++) {
            if (_wordcount > 0) {
                bool retry = true;
                do {
                    int instance = pick.Next(0, _words.Count());
                    if (!_words[instance].checkHidden()) {
                        _words[instance].SetHidden(true);
                        _wordcount -= 1;
                        retry = false;
                    }
                } while (retry);
            }
        }
    }

    public bool CheckHidden() {
        return _isFullyHidden;
    }

    //Clears the console and displays the scripture
    public void Display() {
        Console.Clear();
        Console.Write(_reference.GetReferenceString());

        for (int i = 0; i < _words.Count(); i++) {
            Console.Write(" " + _words[i].GetWordString());
        }

        Console.WriteLine();
    }
}