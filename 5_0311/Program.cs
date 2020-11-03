﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5_0311
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3n+1

            //TreiNPlus1();

        }

        private static void TreiNPlus1()
        {
            int a = 7, b = 1000; // intervalul [a, b]


            int value = a, lungimeMaxima = 1;

            for (int nr = a; nr <= b; nr++)
            {
                (int lungimeSecventa, int maxim) result = TreiNPlus1(nr);

                if (result.lungimeSecventa > lungimeMaxima)
                {
                    lungimeMaxima = result.lungimeSecventa;
                    value = nr;
                }
                Console.WriteLine($"Lungimea secventei este {result.lungimeSecventa}");
                Console.WriteLine($"Cea mai mare valoare din secventa este {result.maxim}{Environment.NewLine}");
            }


            Console.WriteLine($"Cea mai lunga secventa pentru numerele din " +
                $"intervalul [{a},{b}] are lungimea {lungimeMaxima} si se obtine pentru {value}");
        }

        /// <summary>
        /// 3n+1
        /// Se genereaza un sir astfel:
        /// x0 = a; (a nr. natural pozitiv). 
        /// x_(n+1) = x_n / 2 daca x_n este par
        /// x_(n+1) = 3*x_n + 1 daca x_n este impar
        /// Conjectura: pentru orice a, numar natural pozitiv, exista n numar natural a.i. x_n = 1;
        /// </summary>
        /// <example>7, 22, 11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1, (4, 2, 1, 4, 2, 1)</example>
        /// <example>42, 21, 64, 32, 16, 8, 4, 2, 1</example>
        private static (int, int) TreiNPlus1(int a)
        {

            int x = a;
            int contor;
            int maxim = a;
            contor = 1;
            Console.Write($"{x} ");
            while (x != 1)
            {
                if (x % 2 == 0)
                {
                    x = x / 2;
                }
                else
                {
                    x = 3 * x + 1;
                }
                contor++;
                if (x > maxim)
                {
                    maxim = x;
                }

                Console.Write($"{x} ");
            }
            Console.WriteLine();
            // Tuple<int, int> result = new Tuple<int, int>(contor, maxim);


            return (contor, maxim);
        }


    }
}
