//*********START MAIN*********
DisplayMenu();

//*********END MAIN*********

static void DisplayMenu()
{
    System.Console.WriteLine("Press enter to continue.");
    string choice = Console.ReadLine();

    while(choice != "3")
    {
        System.Console.WriteLine("\n1. Full Triangle\n2. Partial Triangle\n3. Exit");
        choice = Console.ReadLine(); //update read

        if(choice == "1")
        {
            GetFull();
        }
        else if(choice == "2")
        {
            GetPartial();
        }
        else if(choice == "3")
        {

        }
        else
        {
            System.Console.WriteLine("Invalid Input.");
        }
    }
}

static void GetFull()
{
    System.Console.WriteLine("Full Triangle");
}

static void GetPartial()
{
    System.Console.WriteLine("Partial Triangle");
}
