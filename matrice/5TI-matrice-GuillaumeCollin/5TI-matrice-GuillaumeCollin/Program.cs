using System;

namespace _5TI_matrice_GuillaumeCollin
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;
            char repeat;
            int[,] matri;
            int[,] matri2;
            int[,] matri3;
            int m;
            int n;
            string matric;
            bool possible = false;
            matricecalc matrice = new matricecalc();
            do
            {
                tryparse(out choix);
                if (choix == 1)
                {
                    Console.WriteLine("combien de ligne voulez vous");
                    m=int.Parse(Console.ReadLine());
                    Console.WriteLine("combien de colone voulez vous");
                    n = int.Parse(Console.ReadLine());

                    matri = new int[m, n];
                    matrice.remplissageMatrice(matri,out matri);
                    matrice.concatMatrice(matri, out matric);
                    Console.WriteLine(matric);
                }
                else if (choix == 2)
                {
                    Console.WriteLine("combien de ligne voulez vous pour la premiere matrice");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("combien de colone voulez vous pour la premiere matrice");
                    n = int.Parse(Console.ReadLine());
                    matri = new int[m, n];
                    matrice.remplissageMatrice(matri, out matri);

                    Console.WriteLine("combien de ligne voulez vous pour la deuxieme matrice");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("combien de colone voulez vous pour la deuxieme matrice");
                    n = int.Parse(Console.ReadLine());
                    matri2 = new int[m, n];
                    matrice.remplissageMatrice(matri2, out matri2);
                    matrice.addiMatrice(matri,matri2, out matri3, possible);
                    if (possible == false)
                    {
                        matrice.concatMatrice(matri3, out matric);
                        Console.WriteLine(matric);
                    }
                    else
                    {
                        Console.WriteLine("addition impossible");
                    }
                }
                else if (choix == 3)
                {
                    Console.WriteLine("combien de ligne voulez vous pour la premiere matrice");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("combien de colone voulez vous pour la premiere matrice");
                    n = int.Parse(Console.ReadLine());
                    matri = new int[m, n];
                    matrice.remplissageMatrice(matri, out matri);

                    Console.WriteLine("combien de ligne voulez vous pour la deuxieme matrice");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("combien de colone voulez vous pour la deuxieme matrice");
                    n = int.Parse(Console.ReadLine());
                    matri2 = new int[m, n];
                    matrice.remplissageMatrice(matri2, out matri2);
                    matrice.multiMatrice(matri, matri2, out matri3, possible);
                    if (possible == false)
                    {
                        matrice.concatMatrice(matri3, out matric);
                        Console.WriteLine(matric);
                    }
                    else
                    {
                        Console.WriteLine("multiplication impossible");
                    }
                }
                Console.WriteLine("vouolez-vous faire autre chose si oui presser la touche y sin non presser n'importe quel touche");
                repeat = char.Parse(Console.ReadLine());
            } while (repeat == 'y');
        }
        static void tryparse(out int choix)
        {
            bool trypasse;

            Console.WriteLine("que voulez vous faire?");
            Console.WriteLine("1 generez le tableaux et le concatener");
            Console.WriteLine("2 addition de 2 matrice ");
            Console.WriteLine("3 multiplication de 2 matrice");
            do
            {

                trypasse = false;

                if (int.TryParse(Console.ReadLine(), out choix))
                {
                    if (choix < 0 || choix > 3)
                    {

                        Console.WriteLine("ERROR ENTREE INCORRECT veuillez entrez une valeur correct");

                        Console.WriteLine("que voulez vous faire?");
                        Console.WriteLine("1 generez le tableaux et le concatener");
                        Console.WriteLine("2 addition de 2 matrice ");
                        Console.WriteLine("3 multiplication de 2 matrice");
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
                    Console.WriteLine("1 generez le tableaux et le concatener");
                    Console.WriteLine("2 addition de 2 matrice ");
                    Console.WriteLine("3 multiplication de 2 matrice");
                }
            } while (trypasse == false);

        }
    }
}
