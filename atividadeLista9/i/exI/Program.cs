using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Digite o nome {0}: ", i);
            string nome = Console.ReadLine();
            nomes.Add(nome); // Adiciona o nome à lista
        }

        // Exibindo a listagem de nomes
        Console.WriteLine("\nListagem de Nomes:");
        for (int i = 1; i <= nomes.Count; i++)
        {
        	Console.WriteLine("{0}° nome: {1}", i, nomes[i]);
         
        }
           Console.ReadKey();
    }
}