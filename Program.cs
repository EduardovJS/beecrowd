﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace beecrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int quadrado = i * i;
                int cubo = i * i * i;

                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
           
        }
    }
}

