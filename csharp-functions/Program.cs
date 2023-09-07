Console.WriteLine("Hello, World!");























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

