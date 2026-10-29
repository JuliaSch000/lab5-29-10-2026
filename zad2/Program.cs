List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Pochodnia"
};

Console.WriteLine($"");

Console.WriteLine($"{plecak.Count}/6");

for (int i = 0; i < plecak.Count; i++)
{
    
    Console.WriteLine($"{i + 1}: {plecak[i]}");
    
}

Console.WriteLine($"");


Console.WriteLine("Podaj nowy przedmiot:");
string newItem = Console.ReadLine()!;
plecak.Add(newItem);


bool maMiksture = plecak.Contains("Mikstura");
bool usunieto = plecak.Remove("Mikstura");

Console.WriteLine($"Znalazłeś {newItem}.");
if (maMiksture)
{
    plecak.Remove("Mikstura");
    if (usunieto)
    {
        Console.WriteLine("Użyłeś mikstury.");
    }
    else
    {
        Console.WriteLine("Nie usunięto mikstury?????");
    }
}

Console.WriteLine($"{plecak.Count}/6");
for (int i = 0; i < plecak.Count; i++)
{
    
    Console.WriteLine($"{i + 1}: {plecak[i]}");
    
}