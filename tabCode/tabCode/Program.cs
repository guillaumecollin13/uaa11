using System;

namespace tabCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbval;
            int nbinter1;
            int nbinter2;
            int[] tabSortie;
            int choix;
            string recom;
            string[] tMois = new string[12];
            string[] tJour = new string[12];
            string[] t3 = new string[tJour.Length+tMois.Length];
            Methodetraitement taboutils = new Methodetraitement();


            recom = "y";
            do
            {
                Console.WriteLine("que voulez vous faire?");
                Console.WriteLine("1 générer un tableau et l'afficher.");
                Console.WriteLine("2 Mélanger deux tableaux(les jours et les mois) et afficher le résultat.");
                Console.WriteLine("3 Générer un tableau d'entier et créer à partir de celui-ci un tableau contenant les valeurs paires et un autre avec les impaires. Les trois tableaux sont affichés.");
                choix = int.Parse(Console.ReadLine());
                if (choix == 1)
                {
                    Console.WriteLine("combien de valeur voulez vous ?");
                    nbval = int.Parse(Console.ReadLine());
                    Console.WriteLine("quelle est la valeur minimal de ces nopmbre");
                    nbinter1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("quelle est la valeur minimal de ces nopmbre");
                    nbinter2 = int.Parse(Console.ReadLine());

                    taboutils.generer(nbval, nbinter1, nbinter2, out tabSortie);
                    for (int compte = 0; compte < nbval - 1; compte++)
                    {
                        Console.Write(tabSortie[compte]);
                    }
                } else if (choix == 2)
                {
                    assign(tJour, tMois, out tJour, tMois);
                    taboutils.tabMelange(tMois, tJour, out t3);
                } else if (choix == 3)
                {

                }
            } while (recom == "y");
        }
        static void assign(string[] tbJour, string[] tbMois,out string[] tJour, string[] tMois)
        {
            for (int i = 0; i < tbJour.Length; i++)
            {
                if (i == %2 )
                {

                }
            }
        }
    }
}
