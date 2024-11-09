using System;

class Program
{
    static void Main()
    {
        int size = 15; // Tamaño del octágono
        PrintOctagon(size);
    }

    static void PrintOctagon(int size)
    {
        int n = size * 2 - 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i < size && j < size - i || i < size && j >= size + i ||
                    i >= size && j < i - size + 1 || i >= size && j >= n - (i - size + 1))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}
