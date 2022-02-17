using System;

namespace Diamantes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // desenho superior do diamante
            Console.WriteLine("digite um numero impar para o diamante");
            int tamanhodiamante = Convert.ToInt32(Console.ReadLine());
            int quantidadeespaços = (tamanhodiamante - 1) / 2;
            int quantidadeX = 1;
            int quantidadeDeLinhaSuperior = (tamanhodiamante - 1) / 2;
            for (int linhas = 0; linhas < quantidadeDeLinhaSuperior; linhas++)
            {
                for (int i = 0; i < quantidadeespaços; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0;i < quantidadeX; i++)
                {
                    Console.Write("x");
                }
                quantidadeespaços--;
                quantidadeX += 2;
                Console.WriteLine();
            }
            for(int coluna = 0;coluna < tamanhodiamante; coluna++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
            quantidadeX = tamanhodiamante - 2;
            quantidadeespaços++;
            for (int linhas = 0; linhas < quantidadeDeLinhaSuperior; linhas++)
            {
                for (int i = 0; i < quantidadeespaços; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < quantidadeX; i++)
                {
                    Console.Write("x");
                }
                quantidadeespaços++;
                quantidadeX -= 2;
                Console.WriteLine();
            }
        }
    }
}
