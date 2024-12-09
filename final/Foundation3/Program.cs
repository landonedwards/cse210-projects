using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new();

        Address lectureAddress = new("", "", "", "");
        Address receptionAddress = new("", "", "", "");
        Address outdoorGatheringAddress = new("", "", "", "");

        Lecture lecture = new("", "", "", "", "", lectureAddress, "", 0);
        events.Add(lecture);

        Reception reception = new("", "", "", "", "", receptionAddress, "");
        events.Add(reception);

        OutdoorGathering outdoorGathering = new("", "", "", "", "", outdoorGatheringAddress, "");
        events.Add(outdoorGathering);

        foreach (Event evnt in events)
        {
            Console.WriteLine(evnt.StandardMessage());
            Console.WriteLine(evnt.FullMessage());
            Console.WriteLine(evnt.ShortMessage());
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