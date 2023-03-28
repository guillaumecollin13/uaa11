using System;
using System.Collections.Generic;
using System.Text;

namespace _5TI_matrice_GuillaumeCollin
{
    class matricecalc
    {
        public void remplissageMatrice(int [,] matri1,int m, int n, out int [,] matri)
        {
            Random alea = new Random();
            matri = new int[m, n];
            for (int i = 0; i < m-1; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    matri[i, j]=alea.Next(0,20);
                }
            }
        }
    }
}
