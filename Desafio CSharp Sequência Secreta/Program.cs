using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_CSharp_Sequência_Secreta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoSequencia = Convert.ToInt32(Console.ReadLine());
            int quantidadeNumerosMarcados = 0;
            int ultimoNumeroLido = 0;
            for (int i = 0; i < tamanhoSequencia; i++)
            {
                int vi = Convert.ToInt32(Console.ReadLine());
                
                if (vi != ultimoNumeroLido)
                ultimoNumeroLido = vi;
                quantidadeNumerosMarcados++;
            }
                Console.WriteLine(quantidadeNumerosMarcados);

            Console.ReadKey();
        }
    }
}