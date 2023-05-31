using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace generateur_phrases_aleatoire // Note: actual namespace depends on the project name.
{
    class Program
    {

        static string ObtenirElementAleatoire(string[] t)
        {

            if(t.Length == 0) {
                return "ERREUR : impossible, tableau vide.";
            }
            var rnd = new Random();
            int i = rnd.Next(t.Length);
            
                
            return t[i];

        }
        static void Main(string[] args)
        {
            // sujet verbe complément
            var sujets = new string[] {
                "Un lapin",
                "Une grand-mère",
                "Un chat",
                "Un bonhomme de neige",
                "Une limace",
                "Une fee",
                "Un magicien",
                "Une tortue",

            };
            var verbes = new string[]
            {
                "mange",
                "écrase",
                "détruit",
                "observe",
                "attrape",
                "regarde",
                "avale",
                "néttoie",
                "se bat avec",
                "s'accroche à",
                "alume",

            };
            var complements = new string[]
            {
                 "un arbre",
                 "un livre",
                 "la lune",
                 "le soleil",
                 "un serpent",
                 "une carte",
                 "une girafe",
                 "le ciel",
                 "une piscine",
                 "un gâteau",
                 "une souris",
                 "un crapaud",

            };

            // sujet = verbe + complément
            // boucle pour NB_PHRASES de fois.

            const int NB_PHRASES = 100; 
            List<string> listePhrases = new List<string>();
            int compteurDoublons = 0;
            for (int i = 0; i < NB_PHRASES; i++)
            {
                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);

                var phrase = sujet + " " + verbe + " " + complement;

                phrase = phrase.Replace("à le", "au");
 
                if(listePhrases.Contains(phrase))
                {
                    compteurDoublons++;
                    i--;
                }
                else
                {
                    listePhrases.Add(phrase);
                }
               
            }
            foreach (var item in listePhrases)
            {
                Console.WriteLine(item); 
            }
            
            Console.WriteLine("Nombre de phrases uniques : " + listePhrases.Count);
            Console.WriteLine("Il y a eu : " + compteurDoublons + " doublons.");
        }
    }
}