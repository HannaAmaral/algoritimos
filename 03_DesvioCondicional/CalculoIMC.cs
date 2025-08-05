using System;

class CalculoIMC
{
	static void Main()
	{
		double peso, altura, imc;
		Console.WriteLine("Digite seu peso(Kg):");
		peso = Double.Parse(Console.ReadLine() );       // "Console.ReadLine" -> é igual ao "leia" do Portugol
		
		Console.WriteLine("Digite Sua Altura (m):");
		altura = Double.Parse(Console.ReadLine() );     // "Double.Parse" -> Transforma o texto em decimal
		
		imc = peso / (altura * altura);
		
		Console.WriteLine("Seu IMC é {0:F3}", imc);
		
		if(imc < 18.5 )
		{
			Console.WriteLine("Classificação: peso");
		}else if ( imc < 25 )
		{
			Console.WriteLine("Classificação: peso normal");
		}else
		{
			Console.WriteLine("Classificação: acima do peso");
		}
	}
}