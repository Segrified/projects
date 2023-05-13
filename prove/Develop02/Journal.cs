using System;
using System.IO;

//An object that holds a list of Entry objects, and can do things with that list
class Journal
{
    public List<Entry> entries = new List<Entry>();

    //Loads Entry objects from a given file
    public void loadEntry() {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines) {
            string[] parts = line.Split("/$/");
            Entry entry = new Entry();

            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];

            entries.Add(entry);
        }
    }

    //Saves Entry objects to a given file
    public void saveEntry() {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename)) {
            for (int i = 0; i < entries.Count; i++) {
                outputFile.WriteLine(entries[i]._date + " /$/ " + entries[i]._prompt + " /$/ " + entries[i]._entry);
            }
        }
    }

    //Displays all the objects the Journal is currently holding
    public void display() {
        for (int i = 0; i < entries.Count; i++) {
            entries[i].display();
        }
    }

    //Uses DateTime to get the date
    public string getDate() {
        DateTime date = DateTime.Today;
        return date.ToString("dd/MM/yyyy");
    }

    //Creates an Entry object, and adds it to the list
    public void makeEntry() {
        Entry entry = new Entry();
        PromtpGenerator generator = new PromtpGenerator();

        string date = getDate();
        entry._date = date;
        string prompt = generator.getPrompt();
        entry._prompt = prompt;

        Console.WriteLine(prompt);
        entry._entry = Console.ReadLine();

        entries.Add(entry);
    }
}