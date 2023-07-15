using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video vid1 = new Video("Turning paint thinner into cherry soda", "NileRed", 2756);
        vid1.newComment("nitrodasnipaz9392", "It's genuinely terrifying how close paint thinner, cherry flavor, and tear gas can be chemically");
        vid1.newComment("jude7225", "While watching him break down and build back and break down and build back chemicals and materials on a molecular level, I'm still impressed and amazed with stir bars.");
        vid1.newComment("emmanuelpittman6319", "Watching your content makes me realize how many super deadly-dangerous chemicals there are that just look like regular water lol");

        Video vid2 = new Video("Do Superconductors Attract Each Other", "The Action Lab", 333);
        vid2.newComment("marcusgalit531", "James once again answers random questions that I never knew I'll always wanted to know the answers for.");
        vid2.newComment("jamesonvparker", "I have a question. If you were to put the magnets on a scale, and then hover a super conductor on top of it, does the weight on the scale increase?");
        vid2.newComment("cult-of-sporque", "I wonder if the 3-body problem is easier or harder to solve with superconductors and magnetic flux versus plain old gravity.");

        Video vid3 = new Video("Why The First Computers Were Made Out Of Light Bulbs", "Veritasium", 1135);
        vid3.newComment("uiouio1891", "Light bulbs were such a good idea, they became the symbol for good ideas");
        vid3.newComment("zezhyrule3", "I've lived my whole life hearing about vacuum tubes and never really knowing how they work. This was an amazing presentation connecting lightbulbs to transistors. I'm stunned.");
        vid3.newComment("Soul-Burn", "Interesting trivia: The first computer bug was a literal moth stuck in a relay in one of these relay calculators!");
        vid3.newComment("caodesignworks2407", "Seeing the progress of computers laid out in a timeline is one of the most fascinating things to me. I've probably seen/ read the story about a dozen times and it's still interesting");

        _videos.Add(vid1);
        _videos.Add(vid2);
        _videos.Add(vid3);

        for (int i = 0; i < _videos.Count(); i++) {
            _videos[i].display();
            Console.WriteLine("");
        }
    }
}