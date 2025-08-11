using System;
using System.ComponentModel;

namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicando = 0, produto;
            bool digitacaoValida = false;

            // ! negação: inverte p vaçpr bppçeamp
            // !false = true
            // !true = false
            // while (digitaçãoValida == false)
            while(!digitacaoValida)
            {
                Console.WriteLine("Digite um número inteiro");
                digitacaoValida = int.TryParse(Console.ReadLine(), out multiplicando);
            }
            Console.WriteLine($"TABUADA DO {multiplicando}");
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                produto = multiplicando * multiplicador;
                Console.WriteLine($"{multiplicando} x {multiplicador} = {produto}");
            }
        }
    }
}
