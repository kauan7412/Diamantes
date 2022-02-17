using System;

namespace Diamantes02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite uma letra para formar o diamante");
            char letraFinal = Convert.ToChar(Console.ReadLine().ToUpper());
            int quantidadeEspacosFora = letraFinal - 'A';
            int quantidadeEspacosDentro = -1;
            for (char letraAtual = 'A'; letraAtual <= letraFinal; letraAtual++)
            {
                if (letraAtual == 'A')
                {
                    Console.WriteLine($"{new string(' ', quantidadeEspacosFora--)}{letraAtual}");
                }
                else
                {
                    Console.WriteLine($"{new string(' ', quantidadeEspacosFora--)}{letraAtual}{new string(' ', quantidadeEspacosDentro += 2)}{letraAtual}");
                }
            }
            quantidadeEspacosDentro += 0;
            quantidadeEspacosFora =1;
            for (char letraAtual =Convert.ToChar(letraFinal-1); letraAtual >= 'A'; letraAtual--)
            {
                if (letraAtual == 'A')
                {
                    Console.WriteLine($"{new string(' ', quantidadeEspacosFora++)}{letraAtual}");
                }
                else
                {
                    Console.WriteLine($"{new string(' ', quantidadeEspacosFora++)}{letraAtual}{new string(' ', quantidadeEspacosDentro -= 2)}{letraAtual}");
                }
            }
        }
    }
}
