using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM2DArrays
{
    class Program
    {
        static double[,] Generate2DArrays(int NumbRows, int NumbCols)
        {
            double[,] arr = new double[NumbRows, NumbCols];
            Random rnd = new Random();
            for (int i = 0; i < NumbRows; i++)
            {
                for (int j = 0; j < NumbCols; j++)
                {
                    arr[i,j] = Math.Round(rnd.NextDouble() * 10, 0);
                }
            }
            return arr;
        }

        static void WriteArray(double[,] arr)
        {
            for (int i=0; i<arr.GetLength(0); i++)
            {
                for (int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static double[,] MultiplArr (double[,] arr1, double [,] arr2)
        {
            double[,] arr3 = new double[arr1.GetLength(0), arr2.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                    for (int k = 0; k < arr1.GetLength(1); k++)
                    {
                        arr3[i, j] += arr1[i, k] * arr2[k, j];
                    }
            }
            return arr3;
        }


        static void Main(string[] args)
        {
            int NumbRows, NumbCols;
            Console.WriteLine("MATR 1:");
            Console.Write("NumbRows = "); NumbRows = int.Parse(Console.ReadLine());
            Console.Write("NumbCols = "); NumbCols = int.Parse(Console.ReadLine());

            double[,] Matr1 = Generate2DArrays(NumbRows, NumbCols);
            WriteArray(Matr1);

            Console.WriteLine("MATR 2:");
            Console.Write("NumbRows = "); NumbRows = int.Parse(Console.ReadLine());
            Console.Write("NumbCols = "); NumbCols = int.Parse(Console.ReadLine());

            double[,] Matr2 = Generate2DArrays(NumbRows, NumbCols);
            WriteArray(Matr2);

            Console.WriteLine("==============================");
            Console.WriteLine("MATR 3:");
            if (Matr1.GetLength(1) == Matr2.GetLength(0))
            {
                double[,] Matr3 = MultiplArr(Matr1, Matr2);
                WriteArray(Matr3);
            }
            else Console.WriteLine("Matr1Cols != Matr2Rows");         
        }
    }
}
