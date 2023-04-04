using System;
using System.Collections.Generic;
using System.Text;

namespace _5TI_matrice_GuillaumeCollin
{
    class matricecalc
    {
        public void remplissageMatrice(int [,] matri1 ,out int [,] matri)
        {
            Random alea = new Random();
            for (int i = 0; i < matri1.GetLength(0); i++)
            {
                for (int j = 0; j < matri1.GetLength(1); j++)
                {
                    matri1[i, j]=alea.Next(0,20);
                }
            } matri = matri1;
        }
        public void concatMatrice(int[,] matri, out string matric)
        {
            matric = "";
            for (int i = 0; i<matri.GetLength(0); i++)
            {
                for (int j = 0; j<matri.GetLength(1); j++)
                {
                    matric=matric+" "+matri[i,j];
                }
                matric = matric + "\n";
            }
        }
        public void addiMatrice(int[,]matri, int[,] matri2, out int[,] matri3, bool possible)
        {
            matri3 = new int[matri2.GetLength(0), matri.GetLength(1)];
            if (matri.GetLength(0) == matri2.GetLength(0) && matri2.GetLength(0) == matri.GetLength(0))
            {
                possible = true;
                for (int ligne = 0; ligne < matri2.GetLength(0); ligne++)
                {
                    for (int colone = 0; colone < matri.GetLength(1); colone++)
                    {
                        matri3[ligne, colone] = matri[ligne, colone] + matri2[ligne, colone];
                    }
                }
            }
            else
            {
                possible = false;
            }
        }
        public void multiMatrice(int[,] matri, int[,] matri2, out int[,] matri3, bool possible)
        {
            matri3 = new int[matri.GetLength(0), matri2.GetLength(1)];
            if (matri.GetLength(0) == matri2.GetLength(1))
            {
                possible = true;
                for (int ligne = 0; ligne < matri2.GetLength(0); ligne++)
                {
                    for (int colone = 0; colone < matri.GetLength(1); colone++)
                    {
                        matri3[ligne, colone] = 0;
                        for (int multi = 0; multi < matri.GetLength(1); multi++)
                        {
                            matri3[ligne, colone] = matri3[ligne, colone] + matri[ligne, colone] * matri2[ligne, colone];
                        }
                    }
                }
            }
            else
            {
                possible = false;
            }
        }
    }
}
