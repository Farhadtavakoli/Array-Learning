using System;

namespace Array_Learing
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Numbers = new int[100];
           
            int[,] Table = new int[10, 10]; 
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Table[i, j] = (i + 1) * (j + 1); // Initialization of the array
                   
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.SetCursorPosition((i * 4) + 10, j * 2 + 4); // Formating the output
                    Console.Write("{0} ", Table[j, i]);
                }
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
