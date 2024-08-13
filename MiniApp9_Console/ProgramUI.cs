namespace MiniApp9_Console;

public class ProgramUI 
{
    public void Run()
    {
        string optionNumber = string.Empty;
        Console.WriteLine("Hello.Welcome to my little app. Please choose what you would like to do from the following menu...");
    
        while (optionNumber != "4" )
        {
            DisplayMenu();  
            optionNumber = ReadSelection();
            switch (optionNumber)
            {
                case "1":
                    AddObject();
                    break;
                case "2":
                    ReadObject();
                    break;
                case "3":
                    DeleteObject();
                    break;
                case "4":
                    ExitApp();
                    break;
                default: 
                    Console.WriteLine("Sorry, that is not a valid choice. Please try again.");
                    break;    
            }
        }

    }

    private void DisplayMenu()
    {
        Console.WriteLine("1. Add Object");
        Console.WriteLine("2. Read Object");
        Console.WriteLine("3. Delete Object");
        Console.WriteLine("4. Exit");
    }
    private string ReadSelection()
    {
        Console.Write("Please enter your selection by one of these numbers: ");
        string input = Console.ReadLine();
        return input;
    }
    private void AddObject()
    {
        Console.WriteLine("Adding the object.");
    }
    private void ReadObject()
    {
        Console.WriteLine("Reading the object.");
    }
    private void DeleteObject()
    {
        Console.WriteLine("Deleting the object.");
    }
    private void ExitApp()
    {
        Console.WriteLine("Goodbye.Hope to see you again soon...");
    }
    private void Default()
    {
        Console.WriteLine("Please press any key to continue."):
        Console.Readkey();
        MiniApp9_Console.Clear();

    }
    // Create stuff
    private void CreateAnimalContent()
    {
        
    }
    // Display the animal content
    private void DisplayAnimalContent()
    {
        System.Console.Clear();

        List<Animal> _animals = AnimalRepo.GetAnimalList();
        foreach (Animal _animal in _animals)
        {
            Console.WriteLine($"Animal; {animal _animal.Name}\n" ):
        }
    }
}
















