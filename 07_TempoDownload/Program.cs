using System;

namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mb = 0, mbps = 0;
            bool mbvalido = false, velocidadevalida = false;
            decimal tempoMinuto, tempoSegundo;

            while (!mbvalido || mb < 0)
            {
                Console.WriteLine("Escreva o tamanho do Arquivo:");
                mbvalido = int.TryParse(Console.ReadLine(), out mb);
                if (!mbvalido || mb < 0)
                {
                    Console.WriteLine("Numero invalido");
                }
            }

            while (!velocidadevalida || mbps < 0)
            {
                Console.WriteLine("Escreva a velocidade da internet:");
                velocidadevalida = int.TryParse(Console.ReadLine(), out mbps);
                if (!velocidadevalida || mbps < 0)
                {
                    Console.WriteLine("Numero invalido");
                }
            }
                tempoSegundo = (mb * 8) / mbps;
                tempoMinuto = tempoSegundo / 60;

                Console.WriteLine("Tempo de dowload: {0:F2} minutos", tempoMinuto);
            
        }
    }
}
