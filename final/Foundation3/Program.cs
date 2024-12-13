using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new();

        Address lectureAddress = new("231 Dimly Lit Room", "The Basement", "Parents' House", 33435);
        Address receptionAddress = new("984 Muddy Creek Road", "Opossum Hollow", "WV", 24801);
        Address outdoorGatheringAddress = new("41 Spud Lane", "Tater Town", "ID", 83721);

        Lecture lecture = new("Why Gamers are The Most Oppressed Group of People", "Lecture", "An informative and enlightening presentation on one of the most controversial topics in recent memory.", "January 11, 2025", "8:00 PM", lectureAddress, "Gamer Gus", 50);
        events.Add(lecture);

        Reception reception = new("Bartholomew and Mildred's Wedding", "Reception", "Join us as we celebrate the beautiful union of Bartholomew and Mildred.", "February 7, 2025", "9:30 PM", receptionAddress, "bartholomewthe4th@gmail.com");
        events.Add(reception);

        OutdoorGathering outdoorGathering = new("Bertram's BBQ", "Outdoor Gathering", "Come for a good time full of games, frostbite, food, and shouting (Betram has a bit of a temper).", "February 21, 2025", "5:30 PM", outdoorGatheringAddress, "Blizzard");
        events.Add(outdoorGathering);

        foreach (Event evnt in events)
        {
            Console.WriteLine();
            Console.WriteLine(evnt.StandardMessage());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(evnt.FullMessage());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(evnt.ShortMessage());
            Console.WriteLine("==============================================");
            
        }

        // lecture.StandardMessage();
        // lecture.FullMessage();
        // lecture.ShortMessage();

        // reception.StandardMessage();
        // reception.FullMessage();
        // reception.ShortMessage();

        // outdoorGathering.StandardMessage();
        // outdoorGathering.FullMessage();
        // outdoorGathering.ShortMessage();
    }
}