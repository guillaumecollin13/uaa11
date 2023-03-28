using System;

namespace _5TI_matrice_GuillaumeCollin
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;
            char repeat;
            matricecalc matrice = new matricecalc();
            do
            {
                tryparse(out choix);
                if (choix == 1)
                {

                }
                else if (choix == 2)
                {
                   
                }
                else if (choix == 3)
                {
                   
                }
                else if (choix == 4)
                {
                   
                }
                Console.WriteLine("vouolez-vous refaire un tri si oui presser la touche y sin non presser n'importe quel touche");
                repeat = char.Parse(Console.ReadLine());
            } while (repeat == 'y');
        }
        static void tryparse(out int choix)
        {
            bool trypasse;

            Console.WriteLine("que voulez vous faire?");
            Console.WriteLine("1 generez le tableaux ");
            Console.WriteLine("2 concatener le tableaux");
            Console.WriteLine("3 addition de 2 matrice ");
            Console.WriteLine("4 multiplication de 2 matrice");
            do
            {

                trypasse = false;

                if (int.TryParse(Console.ReadLine(), out choix))
                {
                    if (choix < 0 || choix > 5)
                    {

                        Console.WriteLine("ERROR ENTREE INCORRECT veuillez entrez une valeur correct");

                        Console.WriteLine("que voulez vous faire?");
                        Console.WriteLine("1 generez le tableaux ");
                        Console.WriteLine("2 concatener le tableaux");
                        Console.WriteLine("3 addition de 2 matrice ");
                        Console.WriteLine("4 multiplication de 2 matrice");
                    }
                    else
                    {
                        trypasse = true;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR ENTREE INCORRECT veuillez entrez une valeur correct");

                    Console.WriteLine("que voulez vous faire?");
                    Console.WriteLine("1 generez le tableaux ");
                    Console.WriteLine("2 concatener le tableaux");
                    Console.WriteLine("3 addition de 2 matrice ");
                    Console.WriteLine("4 multiplication de 2 matrice");

                }
            } while (trypasse == false);

        }
    }
}
