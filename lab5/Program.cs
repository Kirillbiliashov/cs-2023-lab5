using lab5.Model;

var vegetables = new List<Vegetable>
{
    new Tomato(3.0),
    new Cucumber(1.5),
    new Onion(0.5),
    new Lettuce(2.0)
};

var salad = new Salad(vegetables);

Console.WriteLine($"total salad calories: {salad.TotalCaloroies}");

Console.WriteLine($"Vegetables in 50 to 100 calories range:");
var matchingVegetables = salad.VegetablesInCaloriesRange(50, 100);
foreach(var vegetable in matchingVegetables)
{
    Console.WriteLine(vegetable);
}

salad.SortVegetablesByQuantity();
Console.WriteLine("vegetables after sorting by quantity: ");
vegetables.ForEach(Console.WriteLine);


