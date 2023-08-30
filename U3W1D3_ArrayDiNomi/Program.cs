using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3W1D3_ArrayDiNomi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Determino la lunghezza dell'array
            Console.WriteLine("Inserisci il numero di elementi da inserire nell'array: ");
            int numeroNomi = int.Parse(Console.ReadLine());
            string[] nomi = new string[numeroNomi];

            // Assegno il valore agli elementi dell'array
            for (int i = 0; i < numeroNomi; i++)
            {
                Console.WriteLine($"Inserisci il nome {i + 1}: ");
                nomi[i] = Console.ReadLine();
            }

            // Cerco il valore di uno specifico elemento
            while (true)
            {
                Console.Write("Inserisci il nome da ricercare (scrivi 'exit' per uscire): ");
                string nomeDaRicercare = Console.ReadLine();
                if (nomeDaRicercare.ToLower() == "exit")
                    break;

                bool nomeTrovato = false;

                for (int i = 0; i < nomi.Length; i++)
                {
                    if (nomi[i].ToLower() == nomeDaRicercare.ToLower())
                    {
                        nomeTrovato = true;
                        break;
                    }
                };

                Console.WriteLine(
                    nomeTrovato
                ? $"Il nome '{nomeDaRicercare}' è presente nell'array."
                : $"Il nome '{nomeDaRicercare}' non è presente nell'array.");
            }

            Console.ReadLine();

        }
        
    }
}
