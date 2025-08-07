using System;

	class ParOuImpar
	
{
	static void Main()
	{
		int numero;
		
		Console.WriteLine("Digite um número:");
		numero = int.Parse(Console.ReadLine());
		
		if (numero % 2 == 0)
		{
			Console.WriteLine("Par.");
		}
		else 
		{
			Console.WriteLine("Impar.");
		}
	}
}