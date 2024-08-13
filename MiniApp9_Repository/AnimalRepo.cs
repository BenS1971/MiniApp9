namespace MiniApp9_Repository;

public class AnimalRepo
{
    private List<Animal> _animals = new List<Animal>();
    
    public Animal AddAnimal (Animal animal)
    {
        if (animal != null)
        {
        _animals.Add(animal);
        return animal;
        }
        return null;
    } 

    public Animal ReadAnimal (string animalName)
    {
        foreach (Animal ben in _animals)
        {
            if (ben.Name == animalName)
            {
                return ben;
            }
        }
        return null;
    }

    public List<Animal> ReadAllAnimals ()
    {
        return _animals;
    }

    public Animal UpdateAnimal (Animal updateAnimal)
    {
        foreach (Animal ben in _animals)
        {
            if (!ben.Name == animalName)
            {
                return ben;
            }
        }
        return null;
    }

    public void DeleteAnimal (string animalName)
    {
       foreach (Animal ben in _animals)
        {
            if (ben.Name == animalName)
            {
                _animals.Remove(ben);
            }
        }
        return null;
    }
}