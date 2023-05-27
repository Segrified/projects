using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "2nd Nephi";
        int chapter = 31;
        string verse = "20-21";
        string passage = "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.";

        Scripture scripture = new Scripture(book, chapter, verse, passage);

        do {
            scripture.Display();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input == "quit") {
                break;
            }
            else {
                scripture.HideWords();
            }

        } while (!scripture.CheckHidden());
    }
}