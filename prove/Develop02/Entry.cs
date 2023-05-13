using System;

//An object that holds a date, prompt, and entry, for a journal to hold, can also display in proper format
class Entry
{
    public string _prompt;
    public string _date;
    public string _entry;

//displays the entry in proper format
    public void display()
    {
        Console.WriteLine("Date: " + _date + " - Prompt: " + _prompt + "\n" + _entry + "\n");
    }
}