// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void AwesomeFunction(int x)
{
    Console.WriteLine($"The argument received by the awesome function is {x}.");
}

AwesomeFunction(189999);

List<string> animationList = new() {"|", "/", "-", "\\"};

        for (int i = 3; i > 0; i--)
        {
            foreach (string s in animationList)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
        

int _duration = 8;

        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    


        string strDuration = Console.ReadLine();
        int duration = int.Parse(strDuration);

        double numOfLoops = Math.Ceiling((double)duration / 10);
        int inhale = 10 * 0.4;
        int exhale = 10 * 0.6;

        Console.WriteLine("Get ready...");
        Spinner();
        Console.WriteLine();

        for (int i = 0; i < numOfLoops; i++)
        {
            Console.WriteLine("Breathe in...");
            Countdown(inhale);

            Console.Write("Now breathe out...");
            Countdown(exhale);

            Console.WriteLine();
        }


    }
}