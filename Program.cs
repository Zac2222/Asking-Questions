//Peer Reviewed by:Amir Smith
//works really well
bool runAgain = true;
    while(runAgain == true)
    {
        string name;
        string awake;

        Console.WriteLine("What is your name?");
        name = Console.ReadLine();

        Console.WriteLine("What time did you wake up today?");
        awake = Console.ReadLine();

        Console.WriteLine($"So {name}, you woke up at {awake} today.");

        string choice = "";
        Console.WriteLine("Would you like to run again? (y/n)");
        while(choice != "yes" & choice != "y" & choice != "no" & choice != "n")
        {
            choice = Console.ReadLine().ToLower();
        }
        
        if(choice == "y" || choice == "yes")
        {
            runAgain = true;
        }
        else if(choice == "n" || choice == "no")
        {
            runAgain = false;
            Console.WriteLine("Now exiting");
        }
    }