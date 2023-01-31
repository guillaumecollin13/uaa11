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
            string[] tMois = new string[12] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            string[] tJour = new string[12] { "31", "28", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31" };
            string[] t3 = new string[tJour.Length + tMois.Length];
            int[] tabEnt = new int[20];
            int[] tabPair = new int[tabEnt.Length];
            int[] tabImp = new int[tabEnt.Length];
            int valInd = 13;
            int[] tab = new int[10] { 12, 9, 3, 13, 10, 13, 15, 13, 5, 16 };
            Methodetraitement taboutils = new Methodetraitement();


            recom = "y";
            do
            {
                Console.Clear();

                tryparse(out choix);
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
                    Console.WriteLine("");
                }
                else if (choix == 2)
                {
                    taboutils.tabMelange(tMois, tJour, out t3);
                    for (int i = 0; i < tJour.Length; i++)
                    {
                        Console.Write(tJour[i] + " ");
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < tMois.Length; i++)
                    {
                        Console.Write(tMois[i] + " ");
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < t3.Length; i++)
                    {
                        Console.Write(t3[i] + ", ");
                    }
                    Console.WriteLine("");
                }
                else if (choix == 3)
                {
                    nbval = 20;
                    nbinter1 = 1;
                    nbinter2 = 100;
                    taboutils.generer(nbval, nbinter1, nbinter2, out tabEnt);
                    taboutils.tabClassPairImp(tabEnt, out tabPair, tabImp);
                    for (int natsu = 0; natsu < tabEnt.Length; natsu++)
                    {
                        Console.Write(tabEnt[natsu] + " ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("voici les nombre paire");
                    for (int mavis = 0; mavis < tabPair.Length; mavis++)
                    {
                        Console.Write(tabPair[mavis] + " ");
                    }
                    Console.WriteLine("");

                    Console.WriteLine("voici les nombre impaire");
                    for (int zeref = 0; zeref < tabImp.Length; zeref++)
                    {
                        Console.Write(tabImp[zeref] + " ");
                    }
                    Console.WriteLine("");
                }
                if (choix == 4)
                {
                    Console.WriteLine("combien de terme voulez vous dans la suite de fibonacci?");
                    nbval = int.Parse(Console.ReadLine());
                    int[] tabfibon = new int[nbval];
                    taboutils.tabFibo(nbval, tabfibon, out tabfibon);
                    for (int i = 0; i < tabfibon.Length; i++)
                    {
                        Console.Write(tabfibon[i] + ",");
                    }
                    Console.WriteLine("");
                }
                else if (choix == 5)
                {
                    for (int i = 0; i < tab.Length; i++)
                    {
                        Console.Write(tab[i] + " ");
                    }
                    Console.WriteLine("");
                    taboutils.tabDecal(valInd, tab, out tab);
                    for (int i = 0; i < tab.Length; i++)
                    {
                        Console.Write(tab[i] + " ");
                    }
                    Console.WriteLine("");
                }

                Console.WriteLine("vouolez-vous continuer si oui presser la touche y sin non presser n'importe quel touche");
                recom = Console.ReadLine();

            } while (recom == "y");
        }
        static void tryparse(out int choix)
        {
            bool trypasse;

            Console.WriteLine("que voulez vous faire?");
            Console.WriteLine("1 générer un tableau et l'afficher.");
            Console.WriteLine("2 Mélanger deux tableaux(les jours et les mois) et afficher le résultat.");
            Console.WriteLine("3 Générer un tableau d'entier et créer à partir de celui-ci un tableau contenant les valeurs paires et un autre avec les impaires. Les trois tableaux sont affichés.");
            Console.WriteLine("4 faire un tableaux de fibonacci");
            Console.WriteLine("5 range les occurrences d'une valeur indésirable à la fin d'un tableau");
            do
            {
                
                trypasse = false;

                if (int.TryParse(Console.ReadLine(), out choix))
                {
                    if (choix<0 || choix>6)
                    {

                        Console.Clear();
                      Console.WriteLine("ERROR ENTREE INCORRECT veuillez entrez une valeur correct");
                        Console.WriteLine("que voulez vous faire?");
                        Console.WriteLine("1 générer un tableau et l'afficher.");
                        Console.WriteLine("2 Mélanger deux tableaux(les jours et les mois) et afficher le résultat.");
                        Console.WriteLine("3 Générer un tableau d'entier et créer à partir de celui-ci un tableau contenant les valeurs paires et un autre avec les impaires. Les trois tableaux sont affichés.");
                        Console.WriteLine("4 faire un tableaux de fibonacci");
                        Console.WriteLine("5 range les occurrences d'une valeur indésirable à la fin d'un tableau");
                    }
                    else
                    {
                        trypasse = true;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR ENTREE INCORRECT veuillez entrez une valeur correct");
                    Console.WriteLine("que voulez vous faire?");
                    Console.WriteLine("1 générer un tableau et l'afficher.");
                    Console.WriteLine("2 Mélanger deux tableaux(les jours et les mois) et afficher le résultat.");
                    Console.WriteLine("3 Générer un tableau d'entier et créer à partir de celui-ci un tableau contenant les valeurs paires et un autre avec les impaires. Les trois tableaux sont affichés.");
                    Console.WriteLine("4 faire un tableaux de fibonacci");
                    Console.WriteLine("5 range les occurrences d'une valeur indésirable à la fin d'un tableau");

                }
            } while (trypasse == false);

        }
    }
}
