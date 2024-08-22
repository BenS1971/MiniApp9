using MiniApp9_Repository;

namespace MiniApp9_Console;

public class ProgramUI 
{
    private AnimalRepo repository = new AnimalRepo();
    public void Run()
    {
        // var repository = new AnimalRepo();
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
        Console.WriteLine("1. Add Animal");
        Console.WriteLine("2. Read Animal");
        Console.WriteLine("3. Delete Animal");
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
        Console.WriteLine("What is the animal species you want to add?");
        string species = Console.ReadLine();
        Console.WriteLine("What is the order of the animal?");
        string order = Console.ReadLine();
        Console.WriteLine("What is the genus of the animal?");
        string genus = Console.ReadLine();
        Console.WriteLine("Finally, what is your animal's common name?");
        string commonName = Console.ReadLine();

        var animal = new Animal();
        animal.Species = species;
        animal.Order = order;
        animal.Genus = genus;
        animal.CommonName = commonName;

        repository.AddAnimal(animal);

        
    }
    private void ReadObject()
    {
        Console.WriteLine("Please enter an animal to read.");
        string input = Console.ReadLine();

        Animal note = repository.ReadAnimal(input);

        Console.WriteLine(note.CommonName);
        Console.WriteLine(note.Species);
        Console.WriteLine(note.Order);
        Console.WriteLine(note.Genus);




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
        Console.WriteLine("Please press any key to continue.");
        Console.ReadKey();
    //    MiniApp9_Console.Clear();

    }
    // Create stuff
    private void CreateAnimalContent()
    {
        System.Console.Clear();
    //   CreateAnimalContent new content = new AnimalContent();
    }
    // Display the animal content
    private void DisplayAnimalContent()
    {
        System.Console.Clear();

 //       List<Animal> _animals = AnimalRepo.GetAnimalList();
 //       foreach (Animal _animal in _animals)
 //       {
 //           Console.WriteLine($"Animal; {animal _animal.Name}\n" ):
 //       }
    }

    //Update the animal content
    private void UpdateAnimal()
    {
        // ReadAllAnimals();
        Console.WriteLine("Please enter animal to update:");
        string oldAnimal = System.Console.ReadLine();
        System.Console.Clear();
        
        // UpdateAnimalContent();
    }

    //Delete Animal content
    private void DeleteAnimal()
    {
        //System.Console.Clear();

    }
}
















