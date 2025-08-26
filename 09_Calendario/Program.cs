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
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            //Descobre a quantidade de dias de um mês
            int DiasDoMes = DateTime.DaysInMonth(ano, mes);

            //Descobre o dia da semana do 1° dia do mês
            //0 = Domingo - 6 = Sábado
            //Gera o primeiro dia do mês em informado pelo usuário
            DateTime PrimeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)PrimeiroDiaMes.DayOfWeek;

            //Matriz de 6 semanas e 5 dias
            int[,] calendario = new int[6, 7];

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

            int[] diasFeriados = RetornaFeriado(mes, ano);
            //impressão do calendário
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (calendario[semana, diaSemana] != 0)
                    {
                        if (diasFeriados.Contains(calendario[semana, diaSemana]) || diaSemana == 0)
                            Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write(calendario[semana, diaSemana].ToString("D2") + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            //Espera o usuario teclar qualquer tecla

            int[] feriados = RetornaFeriado(mes, ano);

            Console.Write("Feriados: ");

            for (int i = 0; i < feriados.Length; i++)
            {
                if (feriados[i] > 0) // só mostra posições preenchidas
                {
                    Console.Write(feriados[i] + " ");
                }
            }
            Console.ReadKey();
        }

        public static int[] RetornaFeriado(int mes, int ano)
        {
            int[] feriados = new int[15];

            int indice = 0;
            //feriados[indice++] = 11;
            //feriados[indice++] = 21;
            if (mes == 1)                 // Janeiro
                feriados[indice++] = 1;   // 01/01 - Confraternização Universal


            else if (mes == 4)            // Abril
            {
                feriados[indice++] = 4;
                feriados[indice++] = 21;  // 21/04 - Tiradentes
            }


            else if (mes == 5)            // Maio
                feriados[indice++] = 1;   // 01/05 - Dia do Trabalho

            else if (mes == 7)            //Julho
                feriados[indice++] = 9;   // 09/07 - Revolução Constitucionalista

            else if (mes == 9)            // Setembro
                feriados[indice++] = 7;   // 07/09 - Independência


            else if (mes == 10)           // Outubro
                feriados[indice++] = 12;  // 12/10 - Nossa Senhora Aparecida


            else if (mes == 11)           // Novembro
            {
                feriados[indice++] = 2;   // 02/11 - Finados
                feriados[indice++] = 15;  // 15/11 - Proclamação da República
                feriados[indice++] = 20;  // 20/11 - Dia da Consciência Negra
            }
            else if (mes == 12)           // Dezembro
                feriados[indice++] = 25;  // 25/12 - Natal

            return feriados;
        }
    }
}
