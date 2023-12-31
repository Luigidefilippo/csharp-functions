﻿Console.WriteLine("Hello, World!");


int[] numeri = { 2, 6, 7, 5, 3, 9 };
Console.WriteLine("Array originale: ");
StampaArray(numeri);

Console.WriteLine("\nArray elevato al quadrato:");
int[] arrayAlQuadrato = ElevaArrayAlQuadrato(numeri);
StampaArray(arrayAlQuadrato);

Console.WriteLine("\nSomma di tutti i numeri nell'array originale: " + sommaElementiArray(numeri));
Console.WriteLine("Somma di tutti i numeri elevati al quadrato: " + sommaElementiArray(arrayAlQuadrato));









//FUNCTION
static void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(","); 
        }
    }
    Console.WriteLine("]");
}

//SQUARE OF A NUMBER 
static int Quadrato(int numero)
{
    return numero * numero;
}

//SQUARE ARRAY 
static int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] risultato = new int[array.Length];   
    for (int i = 0;i < array.Length;i++) 
    {
        risultato[i] = Quadrato(array[i]);
    }
    return risultato;
}

//RESULT ARRAY

static int sommaElementiArray(int[] array)
{
    int somma = 0;
    foreach (int numero  in array)
    {
        somma += numero;
    }
    return somma;
}