using System;

namespace tritableuax_Guilaume_collin
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbVal;
            int valMin;
            int valMax;
            int choix;
            char repeat; 
            methodedetri triprop =new methodedetri();
            Console.WriteLine("combien de valeurs voulez vous dans le tableaux");
            nbVal = int.Parse(Console.ReadLine());
            int[] tabDeBase = new int[nbVal];
            int[] tabReponse = new int[tabDeBase.Length]; 
            Console.WriteLine("quelle est la valeurs minimum ?");
            valMin = int.Parse(Console.ReadLine());
            Console.WriteLine("quelle est la valeurs maximal ?");
            valMax = int.Parse(Console.ReadLine());
            Random alea = new Random();
            for (int link = 0; link < (nbVal - 1); link++)
            {
                tabDeBase[link] = alea.Next(valMin, valMax);
            }
            for (int zeref = 0; zeref < (nbVal-1); zeref++)
            {
                Console.Write(tabDeBase[zeref] + " ");
            }
            Console.WriteLine("");
            do
            {
               tryparse(out choix);
                if (choix == 1)
                {
                    triprop.triBulle(tabDeBase ,out tabReponse);
                    for (int zeref = 0; zeref < (tabReponse.Length- 1); zeref++)
                    {
                        Console.Write(tabReponse[zeref] + " ");
                    }
                    Console.WriteLine("");
                }
                else if(choix == 2)
                {
                    triprop.triInsertion(tabDeBase, out tabReponse);
                    for (int zeref = 0; zeref < (tabReponse.Length - 1); zeref++)
                    {
                        Console.Write(tabReponse[zeref] + " ");
                    }
                    Console.WriteLine("");
                }
                else if(choix == 3)
                {
                    triprop.triIntuitif( tabDeBase, out tabReponse);
                    for (int zeref = 0; zeref < (tabReponse.Length - 1); zeref++)
                    {
                        Console.Write(tabReponse[zeref] + " ");
                    }
                    Console.WriteLine("");
                }
                else if (choix == 4)
                {
                    triprop.triSelection(tabDeBase, out tabReponse);
                    for (int zeref = 0; zeref < (tabReponse.Length - 1); zeref++)
                    {
                        Console.Write(tabReponse[zeref] + " ");
                    }
                    Console.WriteLine("");
                }
                else if (choix == 5)
                {
                    triprop.trishell(tabDeBase, out tabReponse);
                    for (int zeref = 0; zeref < (tabReponse.Length - 1); zeref++)
                    {
                        Console.Write(tabReponse[zeref] + " ");
                    }
                    Console.WriteLine("");
                }
                    Console.WriteLine("vouolez-vous refaire un tri si oui presser la touche y sin non presser n'importe quel touche");
                repeat = char.Parse(Console.ReadLine());
            } while (repeat =='y');
            
        }
        static void tryparse(out int choix)
        {
            bool trypasse;

            Console.WriteLine("quel methode de tris voulez vous utilisez ?");
            Console.WriteLine("1 tri bulle ");
            Console.WriteLine("2 tri insertion ");
            Console.WriteLine("3 tri intuitif ");
            Console.WriteLine("4 tri selection");
            Console.WriteLine("5 tri shell");
            do
            {

                trypasse = false;

                if (int.TryParse(Console.ReadLine(), out choix))
                {
                    if (choix < 0 || choix > 6)
                    {

                        Console.WriteLine("ERROR ENTREE INCORRECT veuillez entrez une valeur correct");

                        Console.WriteLine("quel methode de tris voulez vous utilisez ?");
                        Console.WriteLine("1 tri bulle ");
                        Console.WriteLine("2 tri insertion ");
                        Console.WriteLine("3 tri intuitif ");
                        Console.WriteLine("4 tri selection");
                        Console.WriteLine("5 tri shell");
                    }
                    else
                    {
                        trypasse = true;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR ENTREE INCORRECT veuillez entrez une valeur correct");

                    Console.WriteLine("quel methode de tris voulez vous utilisez ?");
                    Console.WriteLine("1 tri bulle ");
                    Console.WriteLine("2 tri insertion ");
                    Console.WriteLine("3 tri intuitif ");
                    Console.WriteLine("4 tri selection");
                    Console.WriteLine("5 tri shell");

                }
            } while (trypasse == false);

        }
    }
}
