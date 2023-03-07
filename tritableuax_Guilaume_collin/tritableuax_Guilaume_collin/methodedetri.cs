﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tritableuax_Guilaume_collin
{
    class methodedetri
    {
        public void triBulle(int[] tabDdepart, out int[] tabdepart)
        {
            int n = (tabDdepart.Length);
            bool permut;
            int passage = 0;
            do
            {
                permut = false;
                for (int i = 0; i < n-2-passage; i++)
                {
                    if (tabDdepart[i]> tabDdepart[i+1])
                    {
                        int permutation = tabDdepart[i];
                        tabDdepart[i] = tabDdepart[i + 1];
                        tabDdepart[i + 1] = permutation;
                        permut = true;
                    }
                }
                passage = passage + 1;
            } while (permut == true);
            tabdepart = tabDdepart;
        }
        public void triInsertion(int[] tabDdepart, out int[] tabReponse)
        {
            int n = (tabDdepart.Length);
            int x;
            bool bpp;
            int i;
            for (int j = 1; j < n-1; j++)
            {
                x = tabDdepart[j];
                i = j - 1;
                bpp = false;
                while (x<tabDdepart[i] && bpp == false)
                {
                    tabDdepart[i + 1] = tabDdepart[i];
                    if (i==0)
                    {
                        bpp = true;
                    }
                    else
                    {
                        i = i - 1;
                    }
                }
                if (bpp)
                {
                    tabDdepart[0] = x;
                }
                else
                {
                    tabDdepart[i + 1] = x;
                }
            }
            tabReponse = tabDdepart;
        }
        public void triIntuitif(int[] tabDdepart, out int[] tabReponse)
        {
            int n = (tabDdepart.Length);
            for (int i = 0; i < n-2; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (tabDdepart[j]< tabDdepart[i])
                    {
                        int echange = tabDdepart[j];
                        tabDdepart[j] = tabDdepart[i];
                        tabDdepart[i] = echange;
                    }
                }
            }
            tabReponse = tabDdepart;
        }



    }
}
