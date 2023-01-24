using System;
using System.Collections.Generic;
using System.Text;

namespace tabCode
{
    public struct Methodetraitement
    {
        public void generer(int nbval, int nbinter1, int nbinter2, out int[] tabSortie)
        {
            tabSortie=new int[nbval];
            Random alea = new Random();
            for (int compt = 0; compt <(nbval-1); compt++)
            {
                tabSortie[compt]= alea.Next(nbinter1, nbinter2);
            }
        }
        public void tabMelange(string[] tMois,string[] tJour, out string[] t3)
        {
            t3 = new string[tJour.Length + tMois.Length];
            for (int i = 0; i <(tJour.Length+tMois.Length); i=i+2)
            {
                t3[i] = tMois[i];
            }
            for (int i = 1; i < (tJour.Length + tMois.Length); i=i+2)
            {
                t3[i] = tJour[i];
            }
        }
    }
}
