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
    int ran = new Random().Next(3,9);
            
    for (int i = ran; i > 0; i--)
    {
        for (int j = i; j < ran; j++)
        {
            Console.Write("O");
        }
        Console.WriteLine();
    }
}

static void GetPartial()
{
    int ran = new Random().Next(3,9);
       
    for (int i = ran; i > 0; i--)
    {
        for (int j = i; j < ran; j++)
        {
            if(j == 3 || j == 6 || j == 9)
            {
                Console.Write(" ");
            }
            Console.Write("O");
        }
        Console.WriteLine();
    }
}
