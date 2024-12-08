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


        Video video2 = new("SURVIVE this plane crash and win $1,000,000!", "MrBeast", 1200);
        Comment v2comment1 = new("MrFeast", "Ha! Classic MrBeast. Keep it up lil bro; making the '-east' family proud!");
        Comment v2comment2 = new("BartholomewThe3rd", "Ah, jolly good show! This was indeed a most productive use of my time.");
        Comment v2comment3 = new("BaldCats4Life", "So uh.. what happened to the other contestants?");
        Comment v2comment4 = new("William G.", "This doesn't seem safe. Edit: It was not.");

        video2.AddComment(v2comment1, v2comment2, v2comment3, v2comment4);
        video2.DisplayInfo();

        Video video3 = new("Let's Play Minecraft Survival #23", "SmelvinPlayz", 845);
        Comment v3comment1 = new("DirtyDan", "You've played over 5 hours now, but you haven't made ANY progress. You should at least have SOME type of shelter by now.");
        Comment v3comment2 = new("PastorTom", "SmelvinPlayz? More like SmelvinSucks! You just spent the entire video walking in circles until you fell down a canyon.");
        Comment v3comment3 = new("NotSmelvinJustAFan", "Dude, I love your videos so much! Waking up to a new video of yours is like an early Christmas! I wish you were MY gaming guru.");
        Comment v3comment4 = new("KrazyKat323", "Bro really hopped on his burner account to hype himself up.");

        video3.AddComment(v3comment1, v3comment2, v3comment3, v3comment4);
        video3.DisplayInfo();

    }
}