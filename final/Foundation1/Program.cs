using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to YouTube");

        Video video1 = new("Red Hot 1000 Degree Knife vs Live Hog", "Kevin's Knives", 620);
        Comment v1comment1 = new("GamerGus67", "That hog squealed like a pig!");
        Comment v1comment2 = new("Sally Gibbons", "Oh my gosh! How can people watch this! This is absolutely apalling. All life is precious; this sentiment is clearly lost on you.");
        Comment v1comment3 = new("JonklerFan352", "@Sally Gibbons bro calm down. it's obviously fake. just let people have fun.");
        Comment v1comment4 = new("ILoveStuartLittle", "I don't know man.. that blood looked pretty realistic.");

        video1.AddComment(v1comment1, v1comment2, v1comment3, v1comment4);
        video1.DisplayInfo();


        Video video2 = new("", "", 0);
        Comment v2comment1 = new("", "");
        Comment v2comment2 = new("", "");
        Comment v2comment3 = new("", "");
        Comment v2comment4 = new("", "");

        video2.AddComment(v2comment1, v2comment2, v2comment3, v2comment4);
        video2.DisplayInfo();

        Video video3 = new("", "", 0);
        Comment v3comment1 = new("", "");
        Comment v3comment2 = new("", "");
        Comment v3comment3 = new("", "");
        Comment v3comment4 = new("", "");

        video3.AddComment(v3comment1, v3comment2, v3comment3, v3comment4);
        video3.DisplayInfo();


        // burner account 
    }
}