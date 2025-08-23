using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o mês (1..12): ");
            int mes = int.Parse( Console.ReadLine() );
            
            Console.Write("Digite o ano: ");
            int ano = int.Parse( Console.ReadLine() );

            //Descobre a quantidade de dias de um mês
            int DiasDoMes = DateTime.DaysInMonth(ano, mes);

            //Descobre o dia da semana do 1° dia do mês
            //0 = Domingo - 6 = Sábado
            //Gera o primeiro dia do mês em informado pelo usuário
            DateTime PrimeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)PrimeiroDiaMes.DayOfWeek;

            //Matriz de 6 semanas e 5 dias
            int[,] calendario = new int[6,7];

            int dia = 1;

            //Preenche a matriz com os dias do mês
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    else if (dia <= DiasDoMes)
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                }
            }
            Console.WriteLine($"\nCalendário de " + $"{PrimeiroDiaMes.ToString("MMMM")} de {ano}");

            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

            //Impressão do calendário
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (calendario[semana, diaSemana] != 0)
                    {
                        Console.Write(calendario[semana, diaSemana].ToString("D2") + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            //Espera o usuario teclar qualquer tecla
            Console.ReadKey();
        }
    }
}
