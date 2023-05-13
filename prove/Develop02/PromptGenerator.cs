using System;

//Holds a list of prompts, ad can give a random one when called.
class PromtpGenerator
{
    public List<string> _prompts = new List<string>();

//List of prompts
    public PromtpGenerator() {
        _prompts.Add("What is one thing I did well today, and one thing I could improve?");
        _prompts.Add("What happened today that made it different from other days?");
        _prompts.Add("How did I help someone else today?");
        _prompts.Add("What is something from today that I want to remember?");
        _prompts.Add("Who is someone new I met today?");
    }

//Gives a random prompt from the list
    public string getPrompt() {
        Random pick = new Random();
        string randPrompt = _prompts[pick.Next(0, 4)];
        return randPrompt;
    }
}