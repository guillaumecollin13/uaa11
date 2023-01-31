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
            int i2 = 0;
            t3 = new string[tJour.Length + tMois.Length];
            for (int i = 0; i <(tJour.Length+tMois.Length-1); i=i+2)
            {
                t3[i] = tMois[i2];
                i2 = i2 + 1;
            }
            i2 = 0;
            for (int i = 1; i < (tJour.Length + tMois.Length); i=i+2)
            {
                t3[i] = tJour[i2];
                i2 = i2 + 1;
            }
        }
        public void tabClassPairImp(int[] tabEnt, out int[] tabPair, int[] tabImp)
        {
            int[] tabPairi = new int[tabEnt.Length];
            int[] tabImpi = new int[tabEnt.Length];
            int comptPair=0;
            int comptImp=0;
            for ( int i = 0;  i < tabEnt.Length; i++)
            {
                tabPairi[i] = 0;
                tabImpi[i] = 0;
            }
            for (int pumpit = 0; pumpit < tabEnt.Length; pumpit++)
            {
                if (tabEnt[pumpit]%2==0)
                {
                    tabPairi[comptPair] = tabEnt[pumpit];
                    comptPair = comptPair + 1;
                    
                }
                else
                {
                    tabImpi[comptImp]= tabEnt[pumpit];
                    comptImp = comptImp + 1;
                }
            }
            tabPair = tabPairi;
            tabImpi = tabImp;
        }
        public void tabDecal(int valInd, int[]tab ,out int[]tab1 )
        {
            int nbOcc = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == valInd)
                {
                    nbOcc = nbOcc + 1;
                }
                else
                {
                    tab[i - nbOcc] = tab[i];
                }
            }
            for (int i = tab.Length-nbOcc; i < tab.Length; i++)
            {
                tab[i] = valInd;       
            }
            tab1 = tab;
        }
        public void tabFibo(int nbval, int[]tabfibon1, out int []tabfibon)
        {
            tabfibon1[0] = 1;
            tabfibon1[1] = 1;
            for (int i = 2; i <nbval; i++)
            {
                tabfibon1[i] = tabfibon1[i - 1] + tabfibon1[i - 2];
            }
            tabfibon = tabfibon1;
        }
    }
}
