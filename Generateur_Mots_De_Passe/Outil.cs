using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForamtionCS
{
    static class Outil
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "Le nombre doit etres positif et non nul merci!");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonalise = null)
        {
            while (true)
            {
                int nombre = DemanderNombre(question);
                if ((nombre >= min) && (nombre <= max))
                {
                    return nombre;
                }
                if(messageErreurPersonalise == null)
                {
                    Console.WriteLine($"ERREUR : Le nombre doit etres compris entre {min} et {max} ");   
                }
                else
                {
                    Console.WriteLine(messageErreurPersonalise);
                }
                Console.WriteLine();
            }


        }
        public static int DemanderNombre(string question)
        {

            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR vous devez entree un nombre");
                    Console.WriteLine();
                }

            }

        }
    }
}
