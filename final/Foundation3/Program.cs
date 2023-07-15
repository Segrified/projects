using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Broad St", "Oxford", "OX1 3AZ", "UK");
        Address address2 = new Address("352 Airport Way", "Wendover", "Nevada", "USA");
        Address address3 = new Address("285 S 1st W", "Rexburg", "Idaho", "USA");

        LectureEvent lecture = new LectureEvent("Mathematics in the Real World", "A discussion about how you really do use mathematics in your everyday life, and your high school teachers were not wrong.", "01 January 2023", "11:30am", address1, "Benjamin Schoolcraft", 300);
        ReceptionEvent reception = new ReceptionEvent("Jacquee and Jake Rodden Reception", "A reception to celebrate the marriage of Jacquee and Jake Rodden", "22 July 2017", "12:30pm", address2, "segrified@gmail.com");
        OutdoorEvent outdoor = new OutdoorEvent("Summer Water Fight", "Come throw water ballons at each other!", "15 July 2023", "6:00pm", address3, "Sunny");

        Console.WriteLine(" -- Event 1 --\n" + lecture.getStandardDetails() + "\n\n" + lecture.getFullDetails() + "\n\n" + lecture.getShortDescription() + "\n");
        Console.WriteLine(" -- Event 2 --\n" + reception.getStandardDetails() + "\n\n" + reception.getFullDetails() + "\n\n" + reception.getShortDescription() + "\n");
        Console.WriteLine(" -- Event 3 --\n" + outdoor.getStandardDetails() + "\n\n" + outdoor.getFullDetails() + "\n\n" + outdoor.getShortDescription());
    }
}