﻿int[] tablicaLiczb = { 1000, 33, 123, 10, 1, 12442, 99, 111 };
Console.Write($"Tablica liczb przed sortowaniem: [");
Wypisz(tablicaLiczb);
var tablicaLiczbPoSortowaniu = Sortowanie(tablicaLiczb);
Console.Write($"Tablica liczb po sortowaniu: [");
Wypisz(tablicaLiczbPoSortowaniu);

int[] Sortowanie(int[] tablica)
{
    bool flaga = true;
    while (flaga)
    {
        for (int licznik = 0; licznik < tablica.Length - 1; licznik++)
        {
            if (tablica[licznik] > tablica[licznik + 1])
            {
                Zamiana(ref tablica[licznik], ref tablica[licznik + 1]);
                flaga = false;
            }
        }

        if (flaga)
            break;
        else
            flaga = true;
    }
    return tablica;
}

void Zamiana(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}
void Wypisz(int[] tablicaLiczb)
{
    for (int i = 0; i < tablicaLiczb.Length; i++)
    {
        if (i == tablicaLiczb.Length - 1)
            Console.Write($"{tablicaLiczb[i]}");
        else
            Console.Write($"{tablicaLiczb[i]}, ");
    }
    Console.Write("]\n");
}
// http://www.algorytm.org/algorytmy-sortowania/sortowanie-babelkowe-bubblesort.html