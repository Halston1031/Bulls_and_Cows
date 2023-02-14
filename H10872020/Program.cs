using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H10872020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0;
            int[] arr = new int[4];
            int[] arr1 = new int[4];
            var input = new char[1];
            do
            {
                Random rand = new Random();
                for (int i = 0; i < 4; i++)
                {
                    arr[i] = rand.Next(1, 10);
                    for (int j = 0; j < i; j++)
                    {
                        while (arr[j] == arr[i])
                        {
                            j = 0;
                            arr[i] = rand.Next(1, 10);
                        }
                    }
                }
                Console.Write("Secret number is: ");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"{arr[i]}");
                }
                do
                {
                    A = 0;
                    B = 0;
                    Console.Write("\nEnter a number:");
                    int number = int.Parse(Console.ReadLine());
                    int n = number;
                    for (int i = 0; i < 4; i++)
                    {
                        arr1[i] = (n % 10); // add last digit 
                        n /= 10;
                    }
                    Array.Reverse(arr1);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            if (i == j)
                            {
                                if (arr[i] == arr1[j])
                                {
                                    A++;
                                }
                            }
                            else if (arr[i] == arr1[j])
                            {
                                B++;
                            }
                        }
                    }
                    Console.WriteLine($"{A}A{B}B");
                } while (A != 4);
                Console.WriteLine("Congratulations!!");
                Console.WriteLine("Play again?(y|n)");
                input[0] = Console.ReadKey().KeyChar;
            } while (input[0] == 'y');
            if (input[0] == 'n')
                Console.WriteLine("\nBye!");
            Console.ReadKey();
        }
    }
}
