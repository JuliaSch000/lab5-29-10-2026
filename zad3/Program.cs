Dictionary<string, int> ceny = new Dictionary<string, int>
{
    { "Mikstura", 15 },
    { "Pochodnia", 5 },
    { "Miecz", 40 }
};



Console.WriteLine($"{ceny.Count}");

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value} sztuk złota");
}

Console.WriteLine("Podaj nazwę przedmiotu");
string newItem = Console.ReadLine()!;

if (ceny.ContainsKey(newItem))
{
    Console.WriteLine($"\nCena: {ceny[newItem]} sztuk złota\n");
}
else
{
    Console.WriteLine("\nNie ma takiego przedmiotu.\n");
}

ceny["Mikstura"] = 12;

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value} sztuk złota");
}