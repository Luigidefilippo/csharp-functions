Console.WriteLine("Hello, World!");























//FUNZIONI 
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