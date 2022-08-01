using LINQAssignment;

List<Pet> pets = new List<Pet>
{
    new Pet
    {
        Name="Vasile",
        Type="Cat",
        Sound="Meow",
        Food="cat food",
        Features=new List<string>{"fur","sharp claws","tail","wiskers","small","grey"},
        Enclosure="small cage"
    },
    new Pet
    {
        Name="Vasile2",
        Type="Dog",
        Sound="Woof",
        Food="dog food",
        Features=new List<string>{"fur","blunt claws","tail","wiskers","big","brown"},
        Enclosure="dog house"
    },
    new Pet
    {
        Name="Vasile3",
        Type="clownfish",
        Sound="...",
        Food="fish food",
        Features=new List<string>{"scales","gills","fins","small","colorful"},
        Enclosure="aquarium"
    },
        new Pet
    {
        Name="Vasile4",
        Type="octopus",
        Sound="...",
        Food="fish food",
        Features=new List<string>{"beak","gills","tentacles","medium","colorful"},
        Enclosure="aquarium"
    },
    new Pet
    {
        Name="Vasile5",
        Type="Rabbit",
        Sound="Squeak",
        Food="vegetables",
        Features=new List<string>{"fur","sharp claws","big ears","wiskers","small","white"},
        Enclosure="small cage"
    },
        new Pet
    {
        Name="Vasile6",
        Type="Cat",
        Sound="Meow",
        Food="milk",
        Features=new List<string>{"fur","sharp claws","tail","wiskers","small","grey"},
        Enclosure="small cage"
    }
};
var searchEngine = new PetSearchEngine(pets);
searchEngine.DisplayEnclosures();
Console.ReadLine();
var pet = searchEngine.GetPetByName("Vasile3");
Console.WriteLine($"{pet.Name} is a {pet.Type} and goes {pet.Sound}");
Console.ReadLine();
var foods = searchEngine.GetFoodsByPetType("Cat");
Console.WriteLine("Cats eat:");
foreach (var food in foods)
{
    Console.WriteLine(food);
}
Console.ReadLine();
var petsByFeature = searchEngine.GetPetsByFeature("sharp claws");
Console.WriteLine("Pets with sharp claws:");
foreach (var item in petsByFeature)
{
    Console.WriteLine($"{item.Name} the {item.Type}");
}