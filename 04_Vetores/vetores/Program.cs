using System;

namespace vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Fulano de tal";

            //Reatribuição do Valor da Variavel
            nome = "Beltrano";
            Console.WriteLine(nome);

            //Declaração de Vetores
            //Sintaxe: tipo[] nomeVariavel = {Valor1, Valor2, Valor3};
            string[] nomes = {"Fulano de tal", "Beltrano", "Sicrano", "João", "José", "Maria"};
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);

            //loop FOR
            //sintaxe: FOR( indice; controle; incremento)
            //.Length
            for (int i = 0; i < nomes.Length; i++) 
            {
                Console.WriteLine("{0}° Nome: {1}", i+1, nomes[i]);
            }

            //Adição dos 100 primeiros números pares
            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine("Número: {0}°", i);
            }

            //Loop foreach
            //Sintaxe: foreach(variavel in vetor)
            foreach (string varNome in nomes)
            {
                Console.WriteLine("Nome: {0}", varNome);
            }
        }
    }
}
