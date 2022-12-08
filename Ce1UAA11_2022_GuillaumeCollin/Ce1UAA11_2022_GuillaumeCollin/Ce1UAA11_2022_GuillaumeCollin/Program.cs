using System;

namespace Ce1UAA11_2022_GuillaumeCollin
{
    class Program
    {
        static void Main(string[] args)
        {
            int valDe = 0;
            int nbpoint;
            int nblancer;
            string valDe2;
            bool compDeux;
            int player;
            string valde2Play1;
            string valde2Play2;
            int nbpointPlay1;
            int nbpointPlay2;
            string rep;
            rep= "y";
            while(rep == "y")
            {
                player = 1;
                compDeux = false;
                nblancer = 0;
                Console.WriteLine("ZANZIBAR");
                verif(out nblancer);
                valDe2 = "";
                nbpoint = 0;
                do
                {
                    MP2(valDe, nblancer, valDe2, out compDeux, nbpoint);
                    if (player == 1)
                    {
                        valde2Play1 = valDe2;
                        nbpointPlay1 = nbpoint;
                    }
                    if (compDeux == false)
                    {
                        player = player + 1;
                    }
                }
                while ((player > 3) || (compDeux = false));
                Console.WriteLine(nbpoint);
                if (compDeux == true)
                {
                    Console.WriteLine("joueur" + player + "vous avez eu 3 2");
                }
                Console.WriteLine("pour recomencez appuyez sur y pour fermer apuyez sur n'importe quelle autre touche");
                rep = Console.ReadLine();
            }    
            
        }
        static void MP1(int valDe, out int nbpoint)
        {
            if (valDe == 1)
            {
                nbpoint = 100;
            }
            else if ((valDe >= 2) && (valDe <= 5))
            {
                nbpoint = valDe;
            }
            else
            {
                nbpoint = 60;
            }
        }
        static void MP2(int valDe, int nblancer, string valDe2, out bool compDeux, int nbpoint)
        {
            valDe2 = "";
            Random alea = new Random();
            compDeux = false;
            int compt2 = 0;
            int pointTour = 0;

            for (int compteur = 1; compteur != 4; compteur++)
            {
                valDe = alea.Next(1,7);
                if (valDe == 2)
                {
                    compt2 = compt2 + 1;
                }
                valDe2 = valDe2 + valDe + " ";
                MP1(valDe, out nbpoint);
                pointTour = pointTour + nbpoint;
            }
            if (compt2 == 3)
            {
                compDeux = true;
            }

        }
        static void verif(out int nblancer)
        {
            int spotify;
            do
            {
                Console.WriteLine("combien de lancer voulez vous? (entrez un entier entre 3 et 9)");
                if (int.TryParse(Console.ReadLine(), out nblancer) == true)
                {
                    spotify = 1;
                }
                else
                {
                    spotify = 0;
                }

            }
            while ((spotify == 0) || ((nblancer<=3 )&& (nblancer>=9)));
        }
    }
}
