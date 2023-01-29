

using PetStoreClassExample;
using System.Collections.Generic;

string userInput = "";

List<DogLeash> dogLeashList = new List<DogLeash>();
List<CatFood> catFoodList = new List<CatFood>();

while (userInput.ToLower() != "exit")
{
    Console.WriteLine("Press 1 to add a dog leash, or 2 to add kitten food");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();

    if (userInput == "1")
    {
        Console.WriteLine("What is the name of your dog leash?");
        userInput= Console.ReadLine();
        var dogLeash = new DogLeash
        {
            Name = userInput,
            Price = 2,
            Quantity = 50,
            Description = "just a leash we said was fancy, it's not.",
            LengthInches = 6,
            Material = "nylon"
        };

        dogLeashList.Add(dogLeash);

        Console.WriteLine($"Dog Leash name: {dogLeash.Name}");

    } else if (userInput == "2")
    {
        var kittenFood = new CatFood();

        kittenFood.Name = "Fancy feast";
        kittenFood.Price = 3;
        kittenFood.Quantity = 1;
        kittenFood.Description = "smells gross, kittens love it";
        kittenFood.WeightPounds = 20;
        kittenFood.KittenFood = true;

        catFoodList.Add(kittenFood);

        string kittenFoodWeight = kittenFood.HowMuchFood();

        Console.WriteLine(kittenFoodWeight);
    }

    Console.WriteLine($"Dog Leash Product Count: {dogLeashList.Count()}");
    Console.WriteLine("Cat Food Product Count: " + catFoodList.Count());
}

