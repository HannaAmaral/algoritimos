using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedi cpf e deixei só em numero
            Console.WriteLine("Digite o Cpf:");
            string cpf = Console.ReadLine();
            cpf =Regex.Replace(cpf, "[^0-9]", "");
            
            //validei pra saber se tinha 11 numeros msm
            if (cpf.Length != 11)
            {
                Console.WriteLine("Cpf deve conter 11 digitos.");
                return;
            }

            //sem repetição
            if (cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" ||
                cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" ||
                cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999"
               )
            {
                Console.WriteLine("Cpf inválido! Números repetidos não são permitidos");
                return;
            }


            int validacao = 10;
            int soma = 0;
            int d10 = 0;

            //calculando o digito 1 (primeiro)
            for (int i = 0; i < 9; i++)
            {
                int resultado = (cpf[i] - '0') * validacao;
                validacao--;
                soma += resultado;
            }

            d10 = soma % 11;
            d10 = (d10 <= 2) ? 0 : 11 - d10;
            
            soma = 0;
            int d11 = 0;
            int validacao1 = 11;
            for (int i = 0; i < 10; i++)
            {
                int resultado = (cpf[i] - '0') * validacao1;
                validacao1--;
                soma += resultado;
            }

            d11 = soma % 11;
            d11 = (d11 <= 2) ? 0 : 11 - d11;

            if ((cpf[9] - '0') == d10 && (cpf[10] - '0') == d11)
            {
                Console.WriteLine("CPF válido.");
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }
        }
    }
}
