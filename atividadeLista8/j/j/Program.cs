/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 10/02/2025
 * Time: 10:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace j
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Pares: ");
			int soma = 0;
			for(int i = 0; i<=100;i++){
				
				if( i % 2 == 0 ){
					
					Console.WriteLine(i);
					soma += i;
				}
				
			}
			
			Console.WriteLine("A soma é: "+ soma);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}