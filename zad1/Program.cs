int[] zlotoWTurach = { 5, 12, 0, 8, 15};
int dobreTury = 0;

for (int i = 0; i < zlotoWTurach.Length; i++)
{

     Console.Write($"Tura {i + 1}: {zlotoWTurach[i]} sztuk złota");
     if (zlotoWTurach[i] >= 10)
    {
        dobreTury++;
    }

    Console.ReadLine();
}

int suma = 0;
foreach (int zloto in zlotoWTurach)
{
    suma += zloto;
}


Console.WriteLine($"Suma złota: {suma}");

double sumaDouble = (double)suma;
double srednia = suma / zlotoWTurach.Length;

Console.WriteLine($"Średnia złota: {srednia}");
Console.WriteLine($"Liczba tur, w których zdobyłeś więcej niż 10 złota: {dobreTury}");


// why

for (int j = (zlotoWTurach.Length - 1); j >= 0 ; j--)
{

     Console.Write($"Tura {j + 1}: {zlotoWTurach[j]} sztuk złota");
    Console.ReadLine();
}
