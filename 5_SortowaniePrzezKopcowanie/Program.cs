﻿int[] tablicaLiczb = { 1000, 33, 123, 10, 1, 12442, 99, 111 };
Console.Write($"Tablica liczb przed sortowaniem: [");
Wypisz(tablicaLiczb);
var tablicaLiczbPoSortowaniu = Sortowanie(tablicaLiczb, 0, tablicaLiczb.Length - 1);
Console.Write($"Tablica liczb po sortowaniu: [");
Wypisz(tablicaLiczbPoSortowaniu);

int[] Sortowanie(int[] tablica, int lewo, int prawo)
{

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
// http://www.algorytm.org/algorytmy-sortowania/sortowanie-stogowe-heapsort.html