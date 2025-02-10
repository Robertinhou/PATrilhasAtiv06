/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 10/02/2025
 * Time: 08:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace d
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Insira um número: ");
			
			int num = int.Parse(Console.ReadLine());
			
			int soma = 0;
			
			for (int i = 1; i <= num; i++){
				
				soma += i;
				
			}
			
			Console.WriteLine("A soma é:"+ soma);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}