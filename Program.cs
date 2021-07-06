using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Print_Only_Number_That_Are_Not_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

            IEnumerable<int> onlyInFirstSet = primeiroArray.Except(segundoArray);

            Console.Write("Não contém os números: ");

            foreach (int number in onlyInFirstSet) Console.Write($"{number} ");

            Console.WriteLine("\n Pressione Enter para sair...");
            Console.Read();
        }
    }
}
