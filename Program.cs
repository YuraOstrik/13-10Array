using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array13._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] A = new int[5];
            int[,] B = new int[3,4];

            Console.WriteLine("Введите 5 элементов");
            for(int i = 0;i < A.Length; i++)
            {
                Console.WriteLine($"Номер {1+i} ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rnd.Next(-100, 101); 
                }
            }

            int max1 = A[0];
            int min1 = A[0];
            int sumA = 0;
            int sumB = 0;

           
            for (int i = 0; i < A.Length; i++)
            {
                sumA += A[i];

                if (A[i] > max1) max1 = A[i];
                if (A[i] < min1) min1 = A[i];
            }

            
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    sumB += B[i, j];

                    if (B[i, j] > max1) max1 = B[i, j];
                    if (B[i, j] < min1) min1 = B[i, j];
                }
            }

            int totalSum = sumA + sumB;

            Console.WriteLine($"Общий максимальный элемент: {max1}");
            Console.WriteLine($"Общий минимальный элемент: {min1}");
            Console.WriteLine($"Общая сумма всех элементов: {totalSum}");
            Console.WriteLine("------------------");


            Console.WriteLine("Первое число - ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Второе число - ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("1 - сложение, 2 - вычитание ");
            string c = Console.ReadLine();

            if( c == "1")
            {
                Console.WriteLine($" = {a + b}");
            }
            else if( c == "2")
            {
                Console.WriteLine($" = {a - b}");
            }





            int[,] arr = new int[5,5]; 
            
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    arr[i, j] = rnd.Next(1,100);
                    Console.Write(arr[i, j] + "\t");
                }
            }
            int min = arr[0, 0];
            int max = arr[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i,j] < min)
                    {
                        min = arr[i,j]; 
                    }
                    else if (arr[i,j] > max){
                        max = arr[i,j];
                    }
                }
            }

            Console.WriteLine($" Max = {max} , min = {min}");
            Console.WriteLine("----------");
            string main1 = Console.ReadLine();

        }
    }
}
