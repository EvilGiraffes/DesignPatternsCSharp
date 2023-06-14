Animal[] animals = new Animal[3];
animals[0] = new Hippo();
animals[1] = new Bord();
animals[2] = new WeedBord();
foreach (Animal animal in animals)
{
    Console.WriteLine("---------------------------------------------");
    animal.MakeSound();
    animal.Fly();
    Console.WriteLine("---------------------------------------------");
}
Console.ReadKey();