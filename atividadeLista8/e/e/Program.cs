/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 10/02/2025
 * Time: 08:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace e
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Insira um número: ");
			
			int num = int.Parse(Console.ReadLine());
			int contadores = 0;
			
			for (int i = 1; i <= num ; i++){
				
				if(num % i == 0 || num % i == num ){
					
					contadores++;
					
				}
				
			}
			
			if(contadores > 2 ){
				
				Console.WriteLine("Não é primo!");
				
			} else{
				Console.WriteLine("É primo!");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}