using System;

	class ClassificaçãoIdade
	
{
	static void Main()
	{
		int idade;
		
		Console.WriteLine("Digite sua idade:");
		idade = int.Parse(Console.ReadLine());
		
		if (idade <= 12)
		{
			Console.WriteLine("Você é Criança.");
		}	
		else if (idade <= 17)
		{
			Console.WriteLine("Você é Adolecente.");
		}
		else if (idade < 60)
		{
			Console.WriteLine("Você é Adulto.");
		}	
		else 
		{
			Console.WriteLine("Você é Idoso.");
		}
	}
}	