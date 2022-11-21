using ForamtionCS;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Generateur_Mot_De_Passe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const int NB_MOTS_DE_PASSE = 10;


            int longueurMotDePasse = Outil.DemanderNombrePositifNonNul("Longueur du mot de passe : ");
            Console.WriteLine();
            int choixAlphabet = Outil.DemanderNombreEntre("Vous voulez un mot de passe avec:\n" +
                "1 - Uniquement des caracteres en minuscule\n" +
                "2 - Des caracteres minuscules et majuscules\n" + 
                "3 - Des caracteres et des chiffres\n" +
                "4 - Caracteres, chiffres et caracteres speciaux\n" +
                "Faite votre choix: ",1, 4);
            Console.WriteLine();

            string minuscule = "abcdefghijklmnopqrstuvwxyz";
            string majuscule = minuscule.ToUpper();
            string chiffre = "0123456789";
            string caractereSpeciaux = "-_#*+&";
            string alphabet;
            string motDePass = "";
            
            Random rand = new Random();

            if (choixAlphabet == 1)
            {
                alphabet = minuscule;
            } 
            else if (choixAlphabet == 2)
            {
                alphabet = minuscule + majuscule;
            }                
            else if(choixAlphabet == 3)
            {
                alphabet = minuscule + majuscule + chiffre;
            }      
            else
            {
                alphabet = minuscule + majuscule + chiffre + caractereSpeciaux;
            }

            int longueurAlphabet = alphabet.Length;

            for (int j = 0; j < NB_MOTS_DE_PASSE; j++)
            {
                motDePass = "";
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, longueurAlphabet);
                    motDePass += alphabet[index]; //equivalent a motDePass = motDePass + alphabet[index]; 

                }
                Console.WriteLine($"Le mot de passe est: {motDePass} ");
            }

            

            
        }
    }
}

