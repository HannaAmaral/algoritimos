using System;
using System.Linq;

namespace _05_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[100];
            string continuar = "S";
            
            //será meu indice para atribuição no vetor
            int contador = 0;

            //Loop while
            //Sintaxe: While( expressão booleana)
            while(continuar.ToUpper() == "S")
            {
                Console.WriteLine("Digite o {0}° nome:", contador+1);
                //Append: adiciona um item no vetor
                nomes[contador] = (Console.ReadLine());

                //incrementar o contador
                contador++;
                Console.WriteLine("Deseja continuar? (S/N)");
                continuar = Console.ReadLine();
            }
            Console.WriteLine("Nomes informados:");
            foreach (string str in nomes)
            {
                if (str != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
