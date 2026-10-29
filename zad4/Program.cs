Console.Write("Ile tur chcesz zapisać? ");
int liczbaTur = int.Parse(Console.ReadLine()!);

int[] zlotoWTurach = new int[liczbaTur];

for (int i = 0; i < zlotoWTurach.Length; i++)
{
    Console.Write($"Ile złota w turze {i + 1}?");
    zlotoWTurach[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Zapisane wyniki:");

foreach (int zloto in zlotoWTurach)
{
    Console.WriteLine(zloto);
}

//


int najmniejsze = zlotoWTurach[0];
int najwieksze = zlotoWTurach[0];

for (int i = 1; i < zlotoWTurach.Length; i++)
{
    if (zlotoWTurach[i] < najmniejsze)
    {
        najmniejsze = zlotoWTurach[i];
    }

    if (zlotoWTurach[i] > najwieksze)
    {
        najwieksze = zlotoWTurach[i];
    }
}

Console.WriteLine($"Najmniejsze: {najmniejsze}");
Console.WriteLine($"Największe: {najwieksze}");

int firstMax = 0;
int firstMaxTurn = 0;
for (int i = 0; i < zlotoWTurach.Length; i++)
{
  
    if (najwieksze == zlotoWTurach[i])
    {
        firstMax = zlotoWTurach[i];
        firstMaxTurn = i + 1;
        break;
    }
    
}


int liczbaMaxTur = 0;
for (int i = 0; i < zlotoWTurach.Length; i++)
{
  
    if (najwieksze == zlotoWTurach[i])
    {
        liczbaMaxTur++;
    }
    
}


int bbNoMoney = 0;
for (int i = 0; i < zlotoWTurach.Length; i++)
{
  
    if (zlotoWTurach[i] == 0)
    {
        bbNoMoney = i + 1;
        break;
    }
    
}


Console.WriteLine($"Pierwszy najlepszy wynik: Tura {firstMaxTurn}: {firstMax}");
Console.WriteLine($"Liczba tur z maksimum: {liczbaMaxTur}");
Console.WriteLine($"Pierwsza tura z zerem: {bbNoMoney}");


