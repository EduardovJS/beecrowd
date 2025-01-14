using System;
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
            // Quantidade de valores que serão recebidos
            int n = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            // Recebe os valores, após verifica se estão dentro do intervalo e prescreve as quantidades de dentro e fora do intervalo
            for (int i = 0; i < n; i++)
            {
                int valores = int.Parse(Console.ReadLine());
                if (valores >= 10 && valores <= 20)
                {
                    dentro++;
                }
                else 
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
